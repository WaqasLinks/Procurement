using Repository.DAL;
using System.Collections.Generic;
using System.Linq;

namespace Procurement.Controllers
{
    public class ProjectController
    {
        private _IProcurementRepository<Project> interfaceObj;
        private Project _gProjModel;
        public ProjectController()
        {
            interfaceObj = new ProcurementRepository<Project>();
        }
        public ProjectController(Project pProjModel)
        {
            interfaceObj = new ProcurementRepository<Project>();
            _gProjModel = pProjModel;
        }
        
        //public Object Create()
        //{
        //    FrmProject frmProject = new FrmProject();
        //    return frmProject;
        //}
        public void Save()
        {
            interfaceObj.InsertModel(_gProjModel);
            interfaceObj.Save();
        }
        public Project GetModelByID(decimal modelId)
        {
            return interfaceObj.GetModelByID(modelId);
        }
        public List<Project> GetModels()
        {
            return interfaceObj.GetModels().ToList<Project>();
        }
        public void UpdateModel(Project model)
        {
            interfaceObj.UpdateModel(model);
            interfaceObj.Save();
        }

        //public void GetMaxProjectCode()
        //{
        //    //interfaceObj.GetModels()

        //    //    public void GetMaxProjectCode()
        //    //{
        //    //    //interfaceObj.GetMaxProjectCode();
        //    //    int maxId = dbEntity.DefaultIfEmpty().Max(p => p == null ? 0 : p.);

        //    //}

        //}
        public decimal GetMaxProjectCode()
        {
            List<Project> Projects = GetModels();
            return Projects.DefaultIfEmpty().Max(p => p == null ? 1 : p.ProjectCode+1);
        }
        public void ReseedProjectPk()
        {
            interfaceObj.ReseedProjectPk();
        }
        public void DeleteModel(decimal modelID)
        {
            interfaceObj.DeleteModel(modelID);
            interfaceObj.Save();
        }

    }
}
