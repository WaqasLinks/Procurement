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
        public void SaveList(decimal ProjectCode,byte bomTypeCode)
        {
            //if (ModelState.IsValid)
            //{ 
            //interfaceObj.DeleteModel(ProjectCode);
             List<BOM> LstBoms = GetModels().AsQueryable().Where(x=>x.ProjectCode==ProjectCode && x.BOMTypeCode==bomTypeCode).ToList<BOM>(); //.Products.where(x => x.StoreId == store.StoreId)
            if (LstBoms.Count > 0)
            {
                foreach (BOM bomModel in LstBoms)
                {
                    interfaceObj.DeleteModel(bomModel.RowAuto);
                }
                 
            }
            foreach (BOM bomModel in _gLstBomModel)
            {
                interfaceObj.InsertModel(bomModel);
            }
            if (_gLstBomModel.Count > 0) interfaceObj.Save();
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
