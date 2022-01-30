using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestBService : ITestBService
    {
        #region Private Variables
        private ITestBRepository _TestBRepo;
        #endregion

        #region Constructors
        public TestBService(ITestBRepository testBRepo)
        {
            _TestBRepo = testBRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestBRepo.GetName();
        }
        #endregion
    }
}
