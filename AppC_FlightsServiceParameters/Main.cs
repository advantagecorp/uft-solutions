/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘AppC_FlightsServiceParameters.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir16 = null;
        public BindDirection bind_dir17 = null;
        public BindDirection bind_dir18 = null;
        public HP.ST.Ext.BasicActivities.DataCursorActivity DataCursorActivity12 = null;
        public BindDirection bind_dir19 = null;
        public HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy DataCursorActivity12_Policy = null;
        public BindDirection bind_dir20 = null;
        public BindDirection bind_dir21 = null;
        public BindDirection bind_dir22 = null;
        public BindDirection bind_dir23 = null;
        public BindDirection bind_dir24 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	Directory.SetCurrentDirectory(this._context.ScriptPath);
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.DataFetchActivity8 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity8");
            _flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.DateIncActivity6 = new HP.ST.Ext.BasicActivities.DateIncActivity(_context,"DateIncActivity6");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.DataExporterActivity10 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity10");
            _flow.DataExporterCloseActivity11 = new HP.ST.Ext.BasicActivities.DataExporterCloseActivity(_context,"DataExporterCloseActivity11");
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.DataDisconnectActivity9 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity9");
            this.DataCursorActivity12 = new HP.ST.Ext.BasicActivities.DataCursorActivity(_context,"DataCursorActivity12");
            this.DataCursorActivity12_Policy = new HP.ST.Fwk.SOAReplayAPI.DataHandling.CursorMovementPolicy();
            _flow.Sequence7 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence7");
            _flow.StServiceCallActivity4 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity4");
            _flow.StServiceCallActivity5 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity5");
            _flow.DataFetchActivity8.Comment = @"";
            _flow.DataFetchActivity8.IconPath = @"";
            _flow.DataFetchActivity8.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity8.QueryClassName = @"HP.ST.Ext.CustomDataProviders.ExcelFileDataQuery";
            XmlDocument DataFetchActivity8_QueryParameters_Document = new XmlDocument();
            DataFetchActivity8_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity8Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>5c9081ff-28ac-461b-9fdd-21252cf9308c</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>FlightCities!Sheet1</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>True</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value>FlightCities</Value></QueryParameter><QueryParameter><Name>FilePath</Name><Value>" + _context.ResourceManager.GetValue("{FlightCities!Sheet1.TablePath}") + "</Value></QueryParameter><QueryParameter><Name>SheetName</Name><Value>Sheet1$</Value></QueryParameter><QueryParameter><Name>ContainsHeadersRow</Name><Value>True</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity8_QueryParameters_Document.LoadXml(xmlDataFetchActivity8Params);
            _flow.DataFetchActivity8.QueryParameters = DataFetchActivity8_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("FlightCities!Sheet1", _flow.DataFetchActivity8);
            this.Activities.Add (_flow.DataFetchActivity8);
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            _flow.StartActivity1.KafkaSSL = new HP.ST.Fwk.KafkaFWK.KafkaSSLProperties();
            _flow.StartActivity1.IsKafkaUsed = false;
            _flow.StartActivity1.KafkaSSL.StrEnableSSL = @"No";
            _flow.StartActivity1.KafkaSSL.SSLCALocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientCertificateLocation = @"";
            _flow.StartActivity1.KafkaSSL.SSLClientKeyLocation = @"";
            _flow.StartActivity1.KafkaSASL = new HP.ST.Fwk.KafkaFWK.KafkaSASLProperties();
            _flow.StartActivity1.KafkaSASL.StrEnableSASL = @"No";
            _flow.StartActivity1.KafkaSASL.StrMechanism = @"GSSAPI";
            _flow.StartActivity1.KafkaSASL.StrServiceName = @"";
            this.Activities.Add (_flow.StartActivity1);
            _flow.DateIncActivity6.OriginalDate =  new DateTime(1,1,1,0,0,0,0);
            _flow.DateIncActivity6.OriginalFormat = @"";
            _flow.DateIncActivity6.Units = @"Days";
            _flow.DateIncActivity6.Amount = (int)2;
            _flow.DateIncActivity6.Comment = @"";
            _flow.DateIncActivity6.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_dateinc.png";
            _flow.DateIncActivity6.Name = @"Increment Date2 days into the future";
            VTDPropertyInfoBase pi31 = new VTDPropertyInfoBase("CurrentDate");
            VTDBaseGetter binding_getter16 = new EnvironmentVariableGetter(pi31);
            VTDPropertyInfoBase pi32 = new VTDPropertyInfoBase("OriginalDate");
            VTDBaseSetter binding_setter16 = new VTDObjectSetter(pi32);
            bind_dir16 = new BindDirection(_flow.StartActivity1,binding_getter16,binding_setter16,BindTargetType.ToInProperty);
            _flow.DateIncActivity6.InDirections.Add(bind_dir16);
            this.Activities.Add (_flow.DateIncActivity6);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (this.DataCursorActivity12);
            _flow.Loop2.Activities.Add (_flow.Sequence7);
            this.Activities.Add (_flow.Loop2);
            _flow.DataExporterActivity10.Comment = @"";
            _flow.DataExporterActivity10.IconPath = @"";
            VTDPropertyInfoBase pi33 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter17 = new VTDObjectGetter(pi33);
            VTDPropertyInfoBase pi34 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter17 = new VTDObjectSetter(pi34);
            binding_setter17 = new StringFormaterDecorator(binding_setter17,"{Step.DataFetchActivity8.OutTable}");
            bind_dir17 = new BindDirection(_flow.DataFetchActivity8,binding_getter17,binding_setter17,BindTargetType.ToInProperty);
            _flow.DataExporterActivity10.InDirections.Add(bind_dir17);
            this.Activities.Add (_flow.DataExporterActivity10);
            _flow.DataExporterCloseActivity11.Comment = @"";
            _flow.DataExporterCloseActivity11.IconPath = @"";
            this.Activities.Add (_flow.DataExporterCloseActivity11);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.DataDisconnectActivity9.Comment = @"";
            _flow.DataDisconnectActivity9.IconPath = @"";
            VTDPropertyInfoBase pi35 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter18 = new VTDObjectGetter(pi35);
            VTDPropertyInfoBase pi36 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter18 = new VTDObjectSetter(pi36);
            binding_setter18 = new StringFormaterDecorator(binding_setter18,"{Step.DataFetchActivity8.OutTable}");
            bind_dir18 = new BindDirection(_flow.DataFetchActivity8,binding_getter18,binding_setter18,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity9.InDirections.Add(bind_dir18);
            this.Activities.Add (_flow.DataDisconnectActivity9);
            this.DataCursorActivity12.Comment = @"";
            this.DataCursorActivity12.IconPath = @"";
            VTDPropertyInfoBase pi37 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter19 = new VTDObjectGetter(pi37);
            VTDPropertyInfoBase pi38 = new VTDPropertyInfoBase("InTable");
            VTDBaseSetter binding_setter19 = new VTDObjectSetter(pi38);
            binding_setter19 = new StringFormaterDecorator(binding_setter19,"{Step.DataFetchActivity8.OutTable}");
            bind_dir19 = new BindDirection(_flow.DataFetchActivity8,binding_getter19,binding_setter19,BindTargetType.ToInProperty);
            this.DataCursorActivity12.InDirections.Add(bind_dir19);
            this.DataCursorActivity12_Policy.StartPosition = CursorStartPosition.FirstRecord;
            this.DataCursorActivity12_Policy.StartAtSpecificRow = 1;
            this.DataCursorActivity12_Policy.StartCondition.ColumnName = "";
            this.DataCursorActivity12_Policy.StartCondition.Comparison = ConditionOperator.Equal;
            this.DataCursorActivity12_Policy.StartCondition.Value = "";
            this.DataCursorActivity12_Policy.EndPosition = CursorEndPosition.LastRecord;
            this.DataCursorActivity12_Policy.EndAtSpecificRow = 1;
            this.DataCursorActivity12_Policy.EndCondition.ColumnName = "";
            this.DataCursorActivity12_Policy.EndCondition.Comparison = ConditionOperator.Equal;
            this.DataCursorActivity12_Policy.EndCondition.Value = "";
            this.DataCursorActivity12_Policy.StepType = CursorStepType.Forward;
            this.DataCursorActivity12_Policy.StepSize = 1;
            this.DataCursorActivity12_Policy.ActionAfterLastRecord = CursorActionAfterLastRecord.Wraparound;
            this.DataCursorActivity12.Policy = this.DataCursorActivity12_Policy;
            this.DataCursorActivity12.ReportStepData = true;
            _flow.Loop2.BeforeExecuteStepEvent += this.DataCursorActivity12.ResetCursor;
            _flow.Sequence7.Comment = @"";
            _flow.Sequence7.IconPath = @"";
            _flow.Sequence7.Name = @"Sequence7";
            _flow.Sequence7.Activities.Add (_flow.StServiceCallActivity4);
            _flow.Sequence7.Activities.Add (_flow.StServiceCallActivity5);
            XmlDocument StServiceCallActivity4_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity4_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity4_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlights xmlns=""HP.SOAQ.SampleApp""><DepartureCity>{DataSource.FlightCities!Sheet1.Departure City}</DepartureCity><ArrivalCity>{DataSource.FlightCities!Sheet1.Arrival City}</ArrivalCity><FlightDate>{Step.OutputProperties.DateIncActivity6.Result}</FlightDate></GetFlights></Body></Envelope>");
            _flow.StServiceCallActivity4.InputEnvelope = StServiceCallActivity4_InputEnvelope_Document;
            _flow.StServiceCallActivity4.Comment = @"";
            _flow.StServiceCallActivity4.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity4.Name = @"GetFlights";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress = _context.ResourceManager == null || String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlights";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity4.Service = @"Flights_Service";
            _flow.StServiceCallActivity4.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity4.Operation = @"GetFlights";
            _flow.StServiceCallActivity4.IsOneWay = false;
            _flow.StServiceCallActivity4.SendRequestToService=true;
            _flow.StServiceCallActivity4.FaultExpected=false;
            _flow.StServiceCallActivity4.IsAsync=false;
            _flow.StServiceCallActivity4.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity4.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi39 = new VTDPropertyInfoBase("Result");
            VTDBaseGetter binding_getter20 = new VTDObjectGetter(pi39);
            VTDPropertyInfoBase pi40 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='FlightDate'][1]");
            VTDBaseSetter binding_setter20 = new VTDXPathSetter(pi40,XmlTypeCode.DateTime);
            bind_dir20 = new BindDirection(_flow.DateIncActivity6,binding_getter20,binding_setter20,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir20);
            VTDPropertyInfoBase pi41 = new VTDPropertyInfoBase("Departure City");
            VTDBaseGetter binding_getter21 = new VTDObjectGetter(pi41);
            VTDPropertyInfoBase pi42 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='DepartureCity'][1]");
            VTDBaseSetter binding_setter21 = new VTDXPathSetter(pi42,XmlTypeCode.String);
            binding_setter21 = new StringFormaterDecorator(binding_setter21,"{DataSource.FlightCities!Sheet1.Departure City}");
            bind_dir21 = new BindDirection(this.DataCursorActivity12,binding_getter21,binding_setter21,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir21);
            VTDPropertyInfoBase pi43 = new VTDPropertyInfoBase("Arrival City");
            VTDBaseGetter binding_getter22 = new VTDObjectGetter(pi43);
            VTDPropertyInfoBase pi44 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='ArrivalCity'][1]");
            VTDBaseSetter binding_setter22 = new VTDXPathSetter(pi44,XmlTypeCode.String);
            binding_setter22 = new StringFormaterDecorator(binding_setter22,"{DataSource.FlightCities!Sheet1.Arrival City}");
            bind_dir22 = new BindDirection(this.DataCursorActivity12,binding_getter22,binding_setter22,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity4.InDirections.Add(bind_dir22);
            XmlDocument StServiceCallActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><GetFlightsResponse xmlns=""HP.SOAQ.SampleApp""><GetFlightsResult><Flight><Airline p1:nil=""true"" /><ArrivalCity p1:nil=""true"" /><ArrivalTime p1:nil=""true"" /><DepartureCity p1:nil=""true"" /><DepartureTime p1:nil=""true"" /><FlightNumber /></Flight></GetFlightsResult></GetFlightsResponse></Body></Envelope>");
            _flow.StServiceCallActivity4.ExpectedOutputProperties = StServiceCallActivity4_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity4.ExpectedFaultProperties = StServiceCallActivity4_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity4.ExpectedOutputAttachments = StServiceCallActivity4_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity4_checkpoints(_flow.StServiceCallActivity4);
            XmlDocument StServiceCallActivity5_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity5_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity5_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><CreateFlightOrder xmlns=""HP.SOAQ.SampleApp""><FlightOrder><Class>Business</Class><CustomerName>John Jackson</CustomerName><DepartureDate>{Step.OutputProperties.DateIncActivity6.Result}</DepartureDate><FlightNumber>{Step.OutputProperties.StServiceCallActivity4.Body.GetFlightsResponse.GetFlightsResult.Flight[1].FlightNumber}</FlightNumber><NumberOfTickets>2</NumberOfTickets></FlightOrder></CreateFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity5.InputEnvelope = StServiceCallActivity5_InputEnvelope_Document;
            _flow.StServiceCallActivity5.Comment = @"";
            _flow.StServiceCallActivity5.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity5.Name = @"CreateFlightOrder";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress = _context.ResourceManager == null || String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity5.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/CreateFlightOrder";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity5.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity5.Service = @"Flights_Service";
            _flow.StServiceCallActivity5.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity5.Operation = @"CreateFlightOrder";
            _flow.StServiceCallActivity5.IsOneWay = false;
            _flow.StServiceCallActivity5.SendRequestToService=true;
            _flow.StServiceCallActivity5.FaultExpected=false;
            _flow.StServiceCallActivity5.IsAsync=false;
            _flow.StServiceCallActivity5.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity5.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi45 = new VTDPropertyInfoBase("OutputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlightsResponse'][1]/*[local-name(.)='GetFlightsResult'][1]/*[local-name(.)='Flight'][{Array0}]/*[local-name(.)='FlightNumber'][1]");
            VTDBaseGetter binding_getter23 = new VTDXPathGetter(pi45,XmlTypeCode.Int);
            binding_getter23 = new XPathGetterDecorator(binding_getter23,"{Array0}",1);
            VTDPropertyInfoBase pi46 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='CreateFlightOrder'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='FlightNumber'][1]");
            VTDBaseSetter binding_setter23 = new VTDXPathSetter(pi46,XmlTypeCode.Int);
            bind_dir23 = new BindDirection(_flow.StServiceCallActivity4,binding_getter23,binding_setter23,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity5.InDirections.Add(bind_dir23);
            VTDPropertyInfoBase pi47 = new VTDPropertyInfoBase("Result");
            VTDBaseGetter binding_getter24 = new VTDObjectGetter(pi47);
            VTDPropertyInfoBase pi48 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='CreateFlightOrder'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='DepartureDate'][1]");
            VTDBaseSetter binding_setter24 = new VTDXPathSetter(pi48,XmlTypeCode.DateTime);
            bind_dir24 = new BindDirection(_flow.DateIncActivity6,binding_getter24,binding_setter24,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity5.InDirections.Add(bind_dir24);
            XmlDocument StServiceCallActivity5_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><CreateFlightOrderResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity5.ExpectedOutputProperties = StServiceCallActivity5_ExpectedOutputProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity5.ExpectedFaultProperties = StServiceCallActivity5_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity5_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity5_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity5_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity5.ExpectedOutputAttachments = StServiceCallActivity5_ExpectedOutputAttachments_Document;
            set_StServiceCallActivity5_checkpoints(_flow.StServiceCallActivity5);
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(), "bin", "ReportResources");
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    