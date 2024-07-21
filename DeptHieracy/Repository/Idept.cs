using DeptHieracy.Models;

namespace DeptHieracy.Repository
{
    public interface Idept
    {
        public List<Dept> getSubDept(Dept dept);
        public List<Dept> getParentDept(Dept dept);
        public List<Dept> GetAll();
    }
}
