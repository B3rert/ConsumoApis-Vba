'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceTekra
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/", ConfigurationName:="ServiceTekra.KTFCertificador")>  _
    Public Interface KTFCertificador
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que la operación CertificacionDocumento no es RPC ni está encapsulada en un documento.
        <System.ServiceModel.OperationContractAttribute(Action:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/CertificacionDo"& _ 
            "cumento", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CertificacionDocumento(ByVal request As ServiceTekra.CertificacionDocumentoRequest) As ServiceTekra.CertificacionDocumentoResponse1
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que la operación AnulacionDocumento no es RPC ni está encapsulada en un documento.
        <System.ServiceModel.OperationContractAttribute(Action:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/AnulacionDocume"& _ 
            "nto", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function AnulacionDocumento(ByVal request As ServiceTekra.AnulacionDocumentoRequest) As ServiceTekra.AnulacionDocumentoResponse1
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/")>  _
    Partial Public Class CertificacionDocumento
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private autenticacionField As AutenticacionCertificacion
        
        Private documentoField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property Autenticacion() As AutenticacionCertificacion
            Get
                Return Me.autenticacionField
            End Get
            Set
                Me.autenticacionField = value
                Me.RaisePropertyChanged("Autenticacion")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property Documento() As String
            Get
                Return Me.documentoField
            End Get
            Set
                Me.documentoField = value
                Me.RaisePropertyChanged("Documento")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/")>  _
    Partial Public Class AutenticacionCertificacion
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private pn_usuarioField As String
        
        Private pn_claveField As String
        
        Private pn_clienteField As Integer
        
        Private pn_contratoField As Integer
        
        Private pn_id_origenField As String
        
        Private pn_ip_origenField As String
        
        Private pn_firmar_emisorField As String
        
        Private pn_validar_identificadorField As String
        
        Private pn_retornar_pdfField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property pn_usuario() As String
            Get
                Return Me.pn_usuarioField
            End Get
            Set
                Me.pn_usuarioField = value
                Me.RaisePropertyChanged("pn_usuario")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property pn_clave() As String
            Get
                Return Me.pn_claveField
            End Get
            Set
                Me.pn_claveField = value
                Me.RaisePropertyChanged("pn_clave")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property pn_cliente() As Integer
            Get
                Return Me.pn_clienteField
            End Get
            Set
                Me.pn_clienteField = value
                Me.RaisePropertyChanged("pn_cliente")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>  _
        Public Property pn_contrato() As Integer
            Get
                Return Me.pn_contratoField
            End Get
            Set
                Me.pn_contratoField = value
                Me.RaisePropertyChanged("pn_contrato")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>  _
        Public Property pn_id_origen() As String
            Get
                Return Me.pn_id_origenField
            End Get
            Set
                Me.pn_id_origenField = value
                Me.RaisePropertyChanged("pn_id_origen")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>  _
        Public Property pn_ip_origen() As String
            Get
                Return Me.pn_ip_origenField
            End Get
            Set
                Me.pn_ip_origenField = value
                Me.RaisePropertyChanged("pn_ip_origen")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>  _
        Public Property pn_firmar_emisor() As String
            Get
                Return Me.pn_firmar_emisorField
            End Get
            Set
                Me.pn_firmar_emisorField = value
                Me.RaisePropertyChanged("pn_firmar_emisor")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>  _
        Public Property pn_validar_identificador() As String
            Get
                Return Me.pn_validar_identificadorField
            End Get
            Set
                Me.pn_validar_identificadorField = value
                Me.RaisePropertyChanged("pn_validar_identificador")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>  _
        Public Property pn_retornar_pdf() As String
            Get
                Return Me.pn_retornar_pdfField
            End Get
            Set
                Me.pn_retornar_pdfField = value
                Me.RaisePropertyChanged("pn_retornar_pdf")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/")>  _
    Partial Public Class AutenticacionAnulacion
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private pn_usuarioField As String
        
        Private pn_claveField As String
        
        Private pn_clienteField As Integer
        
        Private pn_contratoField As Integer
        
        Private pn_firmar_emisorField As String
        
        Private pn_retornar_pdfField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property pn_usuario() As String
            Get
                Return Me.pn_usuarioField
            End Get
            Set
                Me.pn_usuarioField = value
                Me.RaisePropertyChanged("pn_usuario")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property pn_clave() As String
            Get
                Return Me.pn_claveField
            End Get
            Set
                Me.pn_claveField = value
                Me.RaisePropertyChanged("pn_clave")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property pn_cliente() As Integer
            Get
                Return Me.pn_clienteField
            End Get
            Set
                Me.pn_clienteField = value
                Me.RaisePropertyChanged("pn_cliente")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>  _
        Public Property pn_contrato() As Integer
            Get
                Return Me.pn_contratoField
            End Get
            Set
                Me.pn_contratoField = value
                Me.RaisePropertyChanged("pn_contrato")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>  _
        Public Property pn_firmar_emisor() As String
            Get
                Return Me.pn_firmar_emisorField
            End Get
            Set
                Me.pn_firmar_emisorField = value
                Me.RaisePropertyChanged("pn_firmar_emisor")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>  _
        Public Property pn_retornar_pdf() As String
            Get
                Return Me.pn_retornar_pdfField
            End Get
            Set
                Me.pn_retornar_pdfField = value
                Me.RaisePropertyChanged("pn_retornar_pdf")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/")>  _
    Partial Public Class CertificacionDocumentoResponse
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private resultadoCertificacionField As String
        
        Private documentoCertificadoField As String
        
        Private representacionGraficaField As String
        
        Private codigoQRField As String
        
        Private nITCertificadorField As String
        
        Private nombreCertificadorField As String
        
        Private numeroAutorizacionField As String
        
        Private numeroDocumentoField As String
        
        Private serieDocumentoField As String
        
        Private fechaHoraCertificacionField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property ResultadoCertificacion() As String
            Get
                Return Me.resultadoCertificacionField
            End Get
            Set
                Me.resultadoCertificacionField = value
                Me.RaisePropertyChanged("ResultadoCertificacion")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property DocumentoCertificado() As String
            Get
                Return Me.documentoCertificadoField
            End Get
            Set
                Me.documentoCertificadoField = value
                Me.RaisePropertyChanged("DocumentoCertificado")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property RepresentacionGrafica() As String
            Get
                Return Me.representacionGraficaField
            End Get
            Set
                Me.representacionGraficaField = value
                Me.RaisePropertyChanged("RepresentacionGrafica")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>  _
        Public Property CodigoQR() As String
            Get
                Return Me.codigoQRField
            End Get
            Set
                Me.codigoQRField = value
                Me.RaisePropertyChanged("CodigoQR")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>  _
        Public Property NITCertificador() As String
            Get
                Return Me.nITCertificadorField
            End Get
            Set
                Me.nITCertificadorField = value
                Me.RaisePropertyChanged("NITCertificador")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>  _
        Public Property NombreCertificador() As String
            Get
                Return Me.nombreCertificadorField
            End Get
            Set
                Me.nombreCertificadorField = value
                Me.RaisePropertyChanged("NombreCertificador")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>  _
        Public Property NumeroAutorizacion() As String
            Get
                Return Me.numeroAutorizacionField
            End Get
            Set
                Me.numeroAutorizacionField = value
                Me.RaisePropertyChanged("NumeroAutorizacion")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer", Order:=7)>  _
        Public Property NumeroDocumento() As String
            Get
                Return Me.numeroDocumentoField
            End Get
            Set
                Me.numeroDocumentoField = value
                Me.RaisePropertyChanged("NumeroDocumento")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>  _
        Public Property SerieDocumento() As String
            Get
                Return Me.serieDocumentoField
            End Get
            Set
                Me.serieDocumentoField = value
                Me.RaisePropertyChanged("SerieDocumento")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=9)>  _
        Public Property FechaHoraCertificacion() As String
            Get
                Return Me.fechaHoraCertificacionField
            End Get
            Set
                Me.fechaHoraCertificacionField = value
                Me.RaisePropertyChanged("FechaHoraCertificacion")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class CertificacionDocumentoRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/", Order:=0)>  _
        Public CertificacionDocumento As ServiceTekra.CertificacionDocumento
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal CertificacionDocumento As ServiceTekra.CertificacionDocumento)
            MyBase.New
            Me.CertificacionDocumento = CertificacionDocumento
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class CertificacionDocumentoResponse1
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/", Order:=0)>  _
        Public CertificacionDocumentoResponse As ServiceTekra.CertificacionDocumentoResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal CertificacionDocumentoResponse As ServiceTekra.CertificacionDocumentoResponse)
            MyBase.New
            Me.CertificacionDocumentoResponse = CertificacionDocumentoResponse
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/")>  _
    Partial Public Class AnulacionDocumento
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private autenticacionField As AutenticacionAnulacion
        
        Private documentoField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property Autenticacion() As AutenticacionAnulacion
            Get
                Return Me.autenticacionField
            End Get
            Set
                Me.autenticacionField = value
                Me.RaisePropertyChanged("Autenticacion")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property Documento() As String
            Get
                Return Me.documentoField
            End Get
            Set
                Me.documentoField = value
                Me.RaisePropertyChanged("Documento")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/")>  _
    Partial Public Class AnulacionDocumentoResponse
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private resultadoAnulacionField As String
        
        Private anulacionCertificadaField As String
        
        Private representacionGraficaField As String
        
        Private codigoQRField As String
        
        Private nITCertificadorField As String
        
        Private nombreCertificadorField As String
        
        Private numeroAutorizacionField As String
        
        Private numeroDocumentoField As String
        
        Private serieDocumentoField As String
        
        Private fechaHoraCertificacionField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>  _
        Public Property ResultadoAnulacion() As String
            Get
                Return Me.resultadoAnulacionField
            End Get
            Set
                Me.resultadoAnulacionField = value
                Me.RaisePropertyChanged("ResultadoAnulacion")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property AnulacionCertificada() As String
            Get
                Return Me.anulacionCertificadaField
            End Get
            Set
                Me.anulacionCertificadaField = value
                Me.RaisePropertyChanged("AnulacionCertificada")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property RepresentacionGrafica() As String
            Get
                Return Me.representacionGraficaField
            End Get
            Set
                Me.representacionGraficaField = value
                Me.RaisePropertyChanged("RepresentacionGrafica")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>  _
        Public Property CodigoQR() As String
            Get
                Return Me.codigoQRField
            End Get
            Set
                Me.codigoQRField = value
                Me.RaisePropertyChanged("CodigoQR")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>  _
        Public Property NITCertificador() As String
            Get
                Return Me.nITCertificadorField
            End Get
            Set
                Me.nITCertificadorField = value
                Me.RaisePropertyChanged("NITCertificador")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>  _
        Public Property NombreCertificador() As String
            Get
                Return Me.nombreCertificadorField
            End Get
            Set
                Me.nombreCertificadorField = value
                Me.RaisePropertyChanged("NombreCertificador")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>  _
        Public Property NumeroAutorizacion() As String
            Get
                Return Me.numeroAutorizacionField
            End Get
            Set
                Me.numeroAutorizacionField = value
                Me.RaisePropertyChanged("NumeroAutorizacion")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer", Order:=7)>  _
        Public Property NumeroDocumento() As String
            Get
                Return Me.numeroDocumentoField
            End Get
            Set
                Me.numeroDocumentoField = value
                Me.RaisePropertyChanged("NumeroDocumento")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=8)>  _
        Public Property SerieDocumento() As String
            Get
                Return Me.serieDocumentoField
            End Get
            Set
                Me.serieDocumentoField = value
                Me.RaisePropertyChanged("SerieDocumento")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=9)>  _
        Public Property FechaHoraCertificacion() As String
            Get
                Return Me.fechaHoraCertificacionField
            End Get
            Set
                Me.fechaHoraCertificacionField = value
                Me.RaisePropertyChanged("FechaHoraCertificacion")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class AnulacionDocumentoRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/", Order:=0)>  _
        Public AnulacionDocumento As ServiceTekra.AnulacionDocumento
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal AnulacionDocumento As ServiceTekra.AnulacionDocumento)
            MyBase.New
            Me.AnulacionDocumento = AnulacionDocumento
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class AnulacionDocumentoResponse1
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://apicertificacion.desa.tekra.com.gt:8080/certificacion/wsdl/", Order:=0)>  _
        Public AnulacionDocumentoResponse As ServiceTekra.AnulacionDocumentoResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal AnulacionDocumentoResponse As ServiceTekra.AnulacionDocumentoResponse)
            MyBase.New
            Me.AnulacionDocumentoResponse = AnulacionDocumentoResponse
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface KTFCertificadorChannel
        Inherits ServiceTekra.KTFCertificador, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class KTFCertificadorClient
        Inherits System.ServiceModel.ClientBase(Of ServiceTekra.KTFCertificador)
        Implements ServiceTekra.KTFCertificador
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceTekra_KTFCertificador_CertificacionDocumento(ByVal request As ServiceTekra.CertificacionDocumentoRequest) As ServiceTekra.CertificacionDocumentoResponse1 Implements ServiceTekra.KTFCertificador.CertificacionDocumento
            Return MyBase.Channel.CertificacionDocumento(request)
        End Function
        
        Public Function CertificacionDocumento(ByVal CertificacionDocumento1 As ServiceTekra.CertificacionDocumento) As ServiceTekra.CertificacionDocumentoResponse
            Dim inValue As ServiceTekra.CertificacionDocumentoRequest = New ServiceTekra.CertificacionDocumentoRequest()
            inValue.CertificacionDocumento = CertificacionDocumento1
            Dim retVal As ServiceTekra.CertificacionDocumentoResponse1 = CType(Me,ServiceTekra.KTFCertificador).CertificacionDocumento(inValue)
            Return retVal.CertificacionDocumentoResponse
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceTekra_KTFCertificador_AnulacionDocumento(ByVal request As ServiceTekra.AnulacionDocumentoRequest) As ServiceTekra.AnulacionDocumentoResponse1 Implements ServiceTekra.KTFCertificador.AnulacionDocumento
            Return MyBase.Channel.AnulacionDocumento(request)
        End Function
        
        Public Function AnulacionDocumento(ByVal AnulacionDocumento1 As ServiceTekra.AnulacionDocumento) As ServiceTekra.AnulacionDocumentoResponse
            Dim inValue As ServiceTekra.AnulacionDocumentoRequest = New ServiceTekra.AnulacionDocumentoRequest()
            inValue.AnulacionDocumento = AnulacionDocumento1
            Dim retVal As ServiceTekra.AnulacionDocumentoResponse1 = CType(Me,ServiceTekra.KTFCertificador).AnulacionDocumento(inValue)
            Return retVal.AnulacionDocumentoResponse
        End Function
    End Class
End Namespace
