
Imports System.Xml.Serialization

<XmlRoot(ElementName:="DatosGenerales")>
Public Class DatosGenerales
    <XmlAttribute(AttributeName:="CodigoMoneda")>
    Public Property CodigoMoneda As String
    <XmlAttribute(AttributeName:="FechaHoraEmision")>
    Public Property FechaHoraEmision As DateTime
    <XmlAttribute(AttributeName:="Tipo")>
    Public Property Tipo As String
End Class

<XmlRoot(ElementName:="DireccionEmisor")>
Public Class DireccionEmisor
    <XmlElement(ElementName:="Direccion")>
    Public Property Direccion As String
    <XmlElement(ElementName:="CodigoPostal")>
    Public Property CodigoPostal As Integer
    <XmlElement(ElementName:="Municipio")>
    Public Property Municipio As String
    <XmlElement(ElementName:="Departamento")>
    Public Property Departamento As String
    <XmlElement(ElementName:="Pais")>
    Public Property Pais As String
End Class

<XmlRoot(ElementName:="Emisor")>
Public Class Emisor
    <XmlElement(ElementName:="DireccionEmisor")>
    Public Property DireccionEmisor As DireccionEmisor
    <XmlAttribute(AttributeName:="AfiliacionIVA")>
    Public Property AfiliacionIVA As String
    <XmlAttribute(AttributeName:="CodigoEstablecimiento")>
    Public Property CodigoEstablecimiento As Integer
    <XmlAttribute(AttributeName:="CorreoEmisor")>
    Public Property CorreoEmisor As Object
    <XmlAttribute(AttributeName:="NITEmisor")>
    Public Property NITEmisor As Integer
    <XmlAttribute(AttributeName:="NombreComercial")>
    Public Property NombreComercial As String
    <XmlAttribute(AttributeName:="NombreEmisor")>
    Public Property NombreEmisor As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="DireccionReceptor")>
Public Class DireccionReceptor
    <XmlElement(ElementName:="Direccion")>
    Public Property Direccion As String
    <XmlElement(ElementName:="CodigoPostal")>
    Public Property CodigoPostal As Integer
    <XmlElement(ElementName:="Municipio")>
    Public Property Municipio As String
    <XmlElement(ElementName:="Departamento")>
    Public Property Departamento As String
    <XmlElement(ElementName:="Pais")>
    Public Property Pais As String
End Class

<XmlRoot(ElementName:="Receptor")>
Public Class Receptor
    <XmlElement(ElementName:="DireccionReceptor")>
    Public Property DireccionReceptor As DireccionReceptor
    <XmlAttribute(AttributeName:="CorreoReceptor")>
    Public Property CorreoReceptor As Object
    <XmlAttribute(AttributeName:="IDReceptor")>
    Public Property IDReceptor As Integer
    <XmlAttribute(AttributeName:="NombreReceptor")>
    Public Property NombreReceptor As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="Frase")>
Public Class Frase
    <XmlAttribute(AttributeName:="CodigoEscenario")>
    Public Property CodigoEscenario As Integer
    <XmlAttribute(AttributeName:="TipoFrase")>
    Public Property TipoFrase As Integer
End Class

<XmlRoot(ElementName:="Frases")>
Public Class Frases
    <XmlElement(ElementName:="Frase")>
    Public Property Frase As Frase
End Class

<XmlRoot(ElementName:="Impuesto")>
Public Class Impuesto
    <XmlElement(ElementName:="NombreCorto")>
    Public Property NombreCorto As String
    <XmlElement(ElementName:="CodigoUnidadGravable")>
    Public Property CodigoUnidadGravable As Integer
    <XmlElement(ElementName:="MontoGravable")>
    Public Property MontoGravable As Double
    <XmlElement(ElementName:="MontoImpuesto")>
    Public Property MontoImpuesto As Double
End Class

<XmlRoot(ElementName:="Impuestos")>
Public Class Impuestos
    <XmlElement(ElementName:="Impuesto")>
    Public Property Impuesto As Impuesto
End Class

<XmlRoot(ElementName:="Item")>
Public Class Item
    <XmlElement(ElementName:="Cantidad")>
    Public Property Cantidad As Double
    <XmlElement(ElementName:="UnidadMedida")>
    Public Property UnidadMedida As String
    <XmlElement(ElementName:="Descripcion")>
    Public Property Descripcion As String
    <XmlElement(ElementName:="PrecioUnitario")>
    Public Property PrecioUnitario As DateTime
    <XmlElement(ElementName:="Precio")>
    Public Property Precio As Double
    <XmlElement(ElementName:="Descuento")>
    Public Property Descuento As Integer
    <XmlElement(ElementName:="Impuestos")>
    Public Property Impuestos As Impuestos
    <XmlElement(ElementName:="Total")>
    Public Property Total As Integer
    <XmlAttribute(AttributeName:="BienOServicio")>
    Public Property BienOServicio As String
    <XmlAttribute(AttributeName:="NumeroLinea")>
    Public Property NumeroLinea As Integer
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="Items")>
Public Class Items
    <XmlElement(ElementName:="Item")>
    Public Property Item As List(Of Item)
End Class

<XmlRoot(ElementName:="TotalImpuesto")>
Public Class TotalImpuesto
    <XmlAttribute(AttributeName:="NombreCorto")>
    Public Property NombreCorto As String
    <XmlAttribute(AttributeName:="TotalMontoImpuesto")>
    Public Property TotalMontoImpuesto As Double
End Class

<XmlRoot(ElementName:="TotalImpuestos")>
Public Class TotalImpuestos
    <XmlElement(ElementName:="TotalImpuesto")>
    Public Property TotalImpuesto As TotalImpuesto
End Class

<XmlRoot(ElementName:="Totales")>
Public Class Totales
    <XmlElement(ElementName:="TotalImpuestos")>
    Public Property TotalImpuestos As TotalImpuestos
    <XmlElement(ElementName:="GranTotal")>
    Public Property GranTotal As Double
End Class

<XmlRoot(ElementName:="DatosEmision")>
Public Class DatosEmision
    <XmlElement(ElementName:="DatosGenerales")>
    Public Property DatosGenerales As DatosGenerales
    <XmlElement(ElementName:="Emisor")>
    Public Property Emisor As Emisor
    <XmlElement(ElementName:="Receptor")>
    Public Property Receptor As Receptor
    <XmlElement(ElementName:="Frases")>
    Public Property Frases As Frases
    <XmlElement(ElementName:="Items")>
    Public Property Items As Items
    <XmlElement(ElementName:="Totales")>
    Public Property Totales As Totales
    <XmlAttribute(AttributeName:="ID")>
    Public Property ID As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="NumeroAutorizacion")>
Public Class NumeroAutorizacion
    <XmlAttribute(AttributeName:="Numero")>
    Public Property Numero As Integer
    <XmlAttribute(AttributeName:="Serie")>
    Public Property Serie As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="Certificacion")>
Public Class Certificacion
    <XmlElement(ElementName:="NITCertificador")>
    Public Property NITCertificador As Integer
    <XmlElement(ElementName:="NombreCertificador")>
    Public Property NombreCertificador As String
    <XmlElement(ElementName:="NumeroAutorizacion")>
    Public Property NumeroAutorizacion As NumeroAutorizacion
    <XmlElement(ElementName:="FechaHoraCertificacion")>
    Public Property FechaHoraCertificacion As DateTime
End Class

<XmlRoot(ElementName:="DTE")>
Public Class DTE
    <XmlElement(ElementName:="DatosEmision")>
    Public Property DatosEmision As DatosEmision
    <XmlElement(ElementName:="Certificacion")>
    Public Property Certificacion As Certificacion
    <XmlAttribute(AttributeName:="ID")>
    Public Property ID As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="SAT")>
Public Class SAT
    <XmlElement(ElementName:="DTE")>
    Public Property DTE As DTE
    <XmlAttribute(AttributeName:="ClaseDocumento")>
    Public Property ClaseDocumento As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="CanonicalizationMethod")>
Public Class CanonicalizationMethod
    <XmlAttribute(AttributeName:="Algorithm")>
    Public Property Algorithm As String
End Class

<XmlRoot(ElementName:="SignatureMethod")>
Public Class SignatureMethod
    <XmlAttribute(AttributeName:="Algorithm")>
    Public Property Algorithm As String
End Class

<XmlRoot(ElementName:="Transform")>
Public Class Transform
    <XmlAttribute(AttributeName:="Algorithm")>
    Public Property Algorithm As String
End Class

<XmlRoot(ElementName:="Transforms")>
Public Class Transforms
    <XmlElement(ElementName:="Transform")>
    Public Property Transform As Transform
End Class

<XmlRoot(ElementName:="DigestMethod")>
Public Class DigestMethod
    <XmlAttribute(AttributeName:="Algorithm")>
    Public Property Algorithm As String
End Class

<XmlRoot(ElementName:="Reference")>
Public Class Reference
    <XmlElement(ElementName:="Transforms")>
    Public Property Transforms As Transforms
    <XmlElement(ElementName:="DigestMethod")>
    Public Property DigestMethod As DigestMethod
    <XmlElement(ElementName:="DigestValue")>
    Public Property DigestValue As String
    <XmlAttribute(AttributeName:="Id")>
    Public Property Id As String
    <XmlAttribute(AttributeName:="URI")>
    Public Property URI As String
    <XmlText>
    Public Property Text As String
    <XmlAttribute(AttributeName:="Type")>
    Public Property Type As String
End Class

<XmlRoot(ElementName:="SignedInfo")>
Public Class SignedInfo
    <XmlElement(ElementName:="CanonicalizationMethod")>
    Public Property CanonicalizationMethod As CanonicalizationMethod
    <XmlElement(ElementName:="SignatureMethod")>
    Public Property SignatureMethod As SignatureMethod
    <XmlElement(ElementName:="Reference")>
    Public Property Reference As List(Of Reference)
End Class

<XmlRoot(ElementName:="SignatureValue")>
Public Class SignatureValue
    <XmlAttribute(AttributeName:="Id")>
    Public Property Id As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="X509IssuerSerial")>
Public Class X509IssuerSerial
    <XmlElement(ElementName:="X509IssuerName")>
    Public Property X509IssuerName As String
    <XmlElement(ElementName:="X509SerialNumber")>
    Public Property X509SerialNumber As Integer
End Class

<XmlRoot(ElementName:="X509Data")>
Public Class X509Data
    <XmlElement(ElementName:="X509Certificate")>
    Public Property X509Certificate As String
    <XmlElement(ElementName:="X509SubjectName")>
    Public Property X509SubjectName As String
    <XmlElement(ElementName:="X509IssuerSerial")>
    Public Property X509IssuerSerial As X509IssuerSerial
End Class

<XmlRoot(ElementName:="KeyInfo")>
Public Class KeyInfo
    <XmlElement(ElementName:="X509Data")>
    Public Property X509Data As X509Data
End Class

<XmlRoot(ElementName:="CertDigest")>
Public Class CertDigest
    <XmlElement(ElementName:="DigestMethod")>
    Public Property DigestMethod As DigestMethod
    <XmlElement(ElementName:="DigestValue")>
    Public Property DigestValue As String
End Class

<XmlRoot(ElementName:="IssuerSerial")>
Public Class IssuerSerial
    <XmlElement(ElementName:="X509IssuerName")>
    Public Property X509IssuerName As String
    <XmlElement(ElementName:="X509SerialNumber")>
    Public Property X509SerialNumber As Integer
End Class

<XmlRoot(ElementName:="Cert")>
Public Class Cert
    <XmlElement(ElementName:="CertDigest")>
    Public Property CertDigest As CertDigest
    <XmlElement(ElementName:="IssuerSerial")>
    Public Property IssuerSerial As IssuerSerial
End Class

<XmlRoot(ElementName:="SigningCertificate")>
Public Class SigningCertificate
    <XmlElement(ElementName:="Cert")>
    Public Property Cert As Cert
End Class

<XmlRoot(ElementName:="SignedSignatureProperties")>
Public Class SignedSignatureProperties
    <XmlElement(ElementName:="SigningTime")>
    Public Property SigningTime As DateTime
    <XmlElement(ElementName:="SigningCertificate")>
    Public Property SigningCertificate As SigningCertificate
End Class

<XmlRoot(ElementName:="SignedProperties")>
Public Class SignedProperties
    <XmlElement(ElementName:="SignedSignatureProperties")>
    Public Property SignedSignatureProperties As SignedSignatureProperties
    <XmlAttribute(AttributeName:="Id")>
    Public Property Id As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="QualifyingProperties")>
Public Class QualifyingProperties
    <XmlElement(ElementName:="SignedProperties")>
    Public Property SignedProperties As SignedProperties
    <XmlAttribute(AttributeName:="xades")>
    Public Property Xades As String
    <XmlAttribute(AttributeName:="xades141")>
    Public Property Xades141 As String
    <XmlAttribute(AttributeName:="Target")>
    Public Property Target As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="ObjectXml")>
Public Class ObjectXml
    <XmlElement(ElementName:="QualifyingProperties")>
    Public Property QualifyingProperties As QualifyingProperties
End Class

<XmlRoot(ElementName:="Signature")>
Public Class Signature
    <XmlElement(ElementName:="SignedInfo")>
    Public Property SignedInfo As SignedInfo
    <XmlElement(ElementName:="SignatureValue")>
    Public Property SignatureValue As SignatureValue
    <XmlElement(ElementName:="KeyInfo")>
    Public Property KeyInfo As KeyInfo
    <XmlElement(ElementName:="ObjectXml")>
    Public Property ObjectXml As ObjectXml
    <XmlAttribute(AttributeName:="ds")>
    Public Property Ds As String
    <XmlAttribute(AttributeName:="Id")>
    Public Property Id As String
    <XmlText>
    Public Property Text As String
End Class

<XmlRoot(ElementName:="GTDocumento")>
Public Class GTDocumento
    <XmlElement(ElementName:="SAT")>
    Public Property SAT As SAT
    <XmlElement(ElementName:="Signature")>
    Public Property Signature As List(Of Signature)
    <XmlAttribute(AttributeName:="dte")>
    Public Property Dte As String
    <XmlAttribute(AttributeName:="Version")>
    Public Property Version As Double
    <XmlText>
    Public Property Text As String
End Class
