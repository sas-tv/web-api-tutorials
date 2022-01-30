using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestGService : ITestGService
    {
        #region Private Variables
        private ITestGRepository _TestGRepo;
        #endregion

        #region Constructors
        public TestGService(ITestGRepository testGRepo)
        {
            _TestGRepo = testGRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestGRepo.GetName();
        }
        #endregion
    }
}
