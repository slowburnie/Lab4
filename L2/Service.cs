using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;


namespace L2
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {
        DataSet holdingsDataSet = new DataSet();
        DataSet industryDataSet = new DataSet();
        DataSet masterDataSet = new DataSet();



        public Datasets GetDatasets()
        {
            

            holdingsDataSet.ReadXml("DB\\holdings.xml");
            masterDataSet.ReadXml("DB\\master.xml");
            industryDataSet.ReadXml("DB\\industry.xml");

            return new Datasets
            {
                HoldingsDataSet = holdingsDataSet,
                IndustryDataSet = industryDataSet,
                MasterDataSet = masterDataSet
            };





        }

        public void Save(Datasets datasets)
        {

            //datasets.HoldingsDataSet.WriteXml("DB\\holdings.xml", XmlWriteMode.WriteSchema);
            //datasets.MasterDataSet.WriteXml("DB\\master.xml", XmlWriteMode.WriteSchema);
            //datasets.IndustryDataSet.WriteXml("DB\\industry.xml", XmlWriteMode.WriteSchema);

            holdingsDataSet = datasets.HoldingsDataSet;
            masterDataSet = datasets.MasterDataSet;
            industryDataSet = datasets.IndustryDataSet;


            holdingsDataSet.WriteXml("DB\\holdings.xml", XmlWriteMode.WriteSchema);
            masterDataSet.WriteXml("DB\\master.xml", XmlWriteMode.WriteSchema);
            industryDataSet.WriteXml("DB\\industry.xml", XmlWriteMode.WriteSchema);
        }
    }
}
