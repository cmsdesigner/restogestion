Option Compare Binary
Option Explicit On 
Option Strict On

Imports System.IO
Imports System.Xml
Imports System.Xml.XPath

'// Classe pour la gestion des fichier XML //
Public Class XMLFile

  Private XDoc As System.Xml.XmlDocument

  '// Constructeurs //
  Public Sub New()
    MyClass.XDoc = New System.Xml.XmlDocument()
  End Sub
  Public Sub New(ByVal XMLFilePath As String)
    Call OpenFile(XMLFilePath)
  End Sub

  '// Permet d'ouviri un fichier pour la lecture ou l'�ctiture //
  Public Sub OpenFile(ByVal XMLFilePath As String)
    Try
      MyClass.XDoc = New System.Xml.XmlDocument()
      MyClass.XDoc.Load(XMLFilePath)
    Catch ex As Exception
      MyClass.XDoc = Nothing
      Throw ex
    End Try
  End Sub

  '// Permet de sauver les modifications du fichier //
  Public Sub SaveFile(ByVal XMLFilePath As String)
    XDoc.Save(XMLFilePath) '// Sauvegarde le fichier
  End Sub

  '// Permet de fermer le fichier //
  Public Sub CloseFile()
    XDoc = Nothing
  End Sub

  '// Cr�e un fichier XML avec le noeud principal //
  Public Sub CreateRoot(Optional ByVal Name As String = "xml")
    XDoc.AppendChild(XDoc.CreateProcessingInstruction("xml", "version=""1.0"" encoding=""utf-8""")) '// En-t�te du fichier
    XDoc.AppendChild(XDoc.CreateElement(Name)) '// Noeud principal
  End Sub

  '// Cr�e un attribut pour un �l�ment //
  Public Function CreateAttribute(ByVal NodePath As String, ByVal Name As String, ByVal Value As String, Optional ByVal Position As Integer = 0) As System.Xml.XmlAttribute
    Dim xNode As System.Xml.XmlNodeList = XDoc.SelectNodes(NodePath)  '// R�cup�re le noeud pour lequel l'attribut sera cr�e
    Dim xAttribute As System.Xml.XmlAttribute = XDoc.CreateAttribute(Name) '// Cr�e l'attribut
    xAttribute.InnerText = Value '// Met la valeur � l'attribut
    xNode.ItemOf(Position).Attributes.Append(xAttribute) '// Ajout de l'attribut
    Return xAttribute
  End Function

  '// Cr�e un �l�ment dans un noeud //
  Public Function CreateElement(ByVal NodePath As String, ByVal Name As String, ByVal Value As String, Optional ByVal Position As Integer = 0) As System.Xml.XmlElement
    Dim xNode As System.Xml.XmlNode = XDoc.SelectNodes(NodePath).ItemOf(Position) '// R�cup�re le noeud ou va �tre cr�e l'attribut
    Dim xElement As System.Xml.XmlElement = XDoc.CreateElement(Name) '// Cr�e l'�l�ment
    xElement.InnerText = Value '// Met la valeur de l'�l�ment
    xNode.AppendChild(xElement) '// Ajoute l'�l�ment
    Return xElement
  End Function

  '// Cr�e un commentaire dans un noeud //
  Public Function CreateComment(ByVal NodePath As String, ByVal Text As String) As System.Xml.XmlComment
    Dim xComment As System.Xml.XmlComment = XDoc.CreateComment(Text) '// Cr�e le commentaire
    If Not NodePath Is Nothing Then
      Dim xNode As System.Xml.XmlNode = XDoc.SelectSingleNode(NodePath) '// R�cup�re le noeud ou va �tre cr�e le commentaire
      xNode.AppendChild(xComment) '// Ajoute le commentaire dans le noeud sp�cifier
    ElseIf NodePath Is Nothing Then
      XDoc.AppendChild(xComment) '// Ajoute le commentaire � la fin du fichier
    End If
    Return xComment
  End Function

  '// Cr�e une section CData dans un noeud //
  Public Function CreateCDataSection(ByVal NodePath As String, ByVal Text As String) As System.Xml.XmlCDataSection
    Dim xCDataSection As System.Xml.XmlCDataSection = XDoc.CreateCDataSection(Text)
    Dim xNode As System.Xml.XmlNode = XDoc.SelectSingleNode(NodePath)
    xNode.AppendChild(xCDataSection)
    Return xCDataSection
  End Function

  '// Modifie la valeur d'un attribut //
  Public Function SetAttribute(ByVal NodePath As String, ByVal Name As String, ByVal Value As String, Optional ByVal Position As Integer = 0) As System.Xml.XmlAttribute
    Dim xNode As System.Xml.XmlNode = XDoc.SelectNodes(NodePath).ItemOf(Position) '// R�cup�re le noeud pour lequel l'attribut va �tre modifier
    Dim xAttribute As System.Xml.XmlAttribute = XDoc.CreateAttribute(Name) '// Cr�� un nouvelle attribut
    xAttribute.InnerText = Value '// Met la nouvelle valeur del'attribut 
    xNode.Attributes.Append(xAttribute) '// Remplace l'ancien attribut par le nouveau
    Return xAttribute
  End Function

  '// Modifie la valeur d'un �l�ment //
  Public Function SetElementValue(ByVal NodePath As String, ByVal Name As String, ByVal Value As String, Optional ByVal Position As Integer = 0) As System.Xml.XmlNode
    Dim xNodeParant As System.Xml.XmlNode = XDoc.SelectNodes(NodePath + "/" + Name).ItemOf(Position).ParentNode '// R�cup�re le noeud ou se trouve l'�l�ment � modifier
    Dim xNode As System.Xml.XmlNode = XDoc.SelectNodes(NodePath + "/" + Name).ItemOf(Position) '// R�cup�re le noeud � modifier

    Dim xNewElement As System.Xml.XmlElement = XDoc.CreateElement(xNode.Name) '// Cr�e un nouvelle �l�ment
    xNewElement.InnerText = Value '//Metla nouvelle valeur de l'�l�ment
    If xNode.HasChildNodes = True Then '// Si le noeud � des enfants
      '// On copie le �l�ment de l'ancien dans le nouveau
      Dim xChildNode As System.Xml.XmlNode
      For Each xChildNode In xNode.ChildNodes
        If Not xChildNode.GetType Is GetType(System.Xml.XmlText) Then
          xNewElement.AppendChild(xChildNode.Clone())
        End If
        xNodeParant.ReplaceChild(xNewElement, xNode)
        xNode = xNewElement
      Next
    ElseIf xNode.HasChildNodes = False Then '// Si le noeud n'a pas d'enfants
      xNodeParant.ReplaceChild(xNewElement, xNode) '// Remplace l'ancien �l�ment par le nouveau
    End If

    Return xNode
  End Function

  '// Supprime un �l�ment //
  Public Sub RemoveElement(ByVal NodePath As String, ByVal Name As String, Optional ByVal Position As Integer = 0)
    Dim xNodeParant As System.Xml.XmlNode = XDoc.SelectSingleNode(NodePath) '// R�cup�re le noeud qui contient l'�l�ment
    Dim xElement As System.Xml.XmlNode = XDoc.SelectNodes(NodePath + "/" + Name).ItemOf(Position) '// R�cup�re l'�l�ment � supprimer
    xNodeParant.RemoveChild(xElement) '// Supprime l'�l�ment
  End Sub

  '// Lit la valeur d'un �l�ment //
  Public Function GetElementValue(ByVal NodePath As String, ByVal Name As String, Optional ByVal Position As Integer = 0) As String
    Return XDoc.SelectNodes(NodePath + "/" + Name).ItemOf(Position).FirstChild.InnerText
  End Function

  '// Lit la valeur d'un attribut //
  Public Function GetAttribute(ByVal NodePath As String, ByVal Name As String, Optional ByVal Position As Integer = 0) As String
    Return XDoc.SelectNodes(NodePath).ItemOf(Position).Attributes.GetNamedItem(Name).InnerText '// Retourne la valeur de l'attribut
  End Function

  '// Retourne l'index de l'�l�ment dont la valeur est sp�cifi� //
  Public Function GetIndexOfElement(ByVal NodePath As String, ByVal Name As String, ByVal Value As String) As Integer
    Dim xNode As XmlNodeList = XDoc.SelectNodes(NodePath + "/" + Name)
    Dim Index As Integer, SearchxNode As XmlElement
    For Each SearchxNode In xNode
      If SearchxNode.InnerText = Value Then Return Index
      Index += 1
    Next
    Return -1
  End Function

  '// Retourne le nombre d'�l�ments dans le n�me noeud donc les noms sont identique //
  Public Function GetCountElements(ByVal NodePath As String, ByVal Name As String) As Integer
    Return XDoc.SelectNodes(NodePath + "/" + Name).Count
  End Function

  '// Efface tout le contenue
  Public Sub Clear()
    XDoc = New System.Xml.XmlDocument()
  End Sub

End Class
