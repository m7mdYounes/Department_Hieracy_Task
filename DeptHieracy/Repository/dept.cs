using DeptHieracy.Models;

namespace DeptHieracy.Repository
{
    public class dept:Idept
    {
        private readonly DepartmentContext db;

        public dept(DepartmentContext db )
        {
            this.db = db;
        }

        public List<Dept> GetAll()
        {
           return db.Depts.ToList();
        }
        public List<Dept> getSubDept(Dept dept)
        {
            return db.Depts.Where(d=>d.Parent_Dept_id == dept.Id).ToList();
        }

        public List<Dept> getParentDept(Dept dept) 
        {
            List<Dept> depts = new List<Dept>();
            int? temp_id = dept.Parent_Dept_id;
            while(temp_id != null)
            {
                Dept parent_dept = db.Depts.Where(d => d.Id == temp_id).SingleOrDefault();
                if (parent_dept != null)
                {
                    depts.Add(parent_dept);
                    temp_id = parent_dept.Id;
                }
                else
                {
                    temp_id = null;
                }
            }
            return depts;
        }
    }
}
