using Repository.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Procurement.Controllers
{
    public class BOMController
    {
        private _IProcurementRepository<BOM> interfaceObj;
        private BOM _gBomModel;
        private List<BOM> _gLstBomModel;
        public BOMController()
        {
            interfaceObj = new ProcurementRepository<BOM>();
         
        }
        public BOMController(BOM pBomModel)
        {
            interfaceObj = new ProcurementRepository<BOM>();
            _gBomModel = pBomModel;
        }
        public BOMController(List<BOM> pLstBomModel)
        {
            interfaceObj = new ProcurementRepository<BOM>();
            _gLstBomModel = pLstBomModel;
        }
        //public Object Create()
        //{
        //    FrmProject frmProject = new FrmProject();
        //    return frmProject;
        //}
        public void Save()
        {
            interfaceObj.InsertModel(_gBomModel);
            interfaceObj.Save();
        }
        public void SaveList()
        {
            //if (ModelState.IsValid)
            //{ 
                foreach (BOM bomModel in _gLstBomModel)
            {
                interfaceObj.InsertModel(bomModel);
            }
            interfaceObj.Save();
            //}

        }
        
        public List<BOM> GetModels()
        {
            return interfaceObj.GetModels().ToList<BOM>();
        }
        //public BOM GetModelByID(decimal projectCode)
        //{
        //    return interfaceObj.GetModelByID(projectCode);
        //}
    }
}
