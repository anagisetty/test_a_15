using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using test_a_15.DTO;
using test_a_15.DataAccess;

namespace test_a_15
{
    public class GoogleDriveConfigurationService
    {
        private readonly GoogleDriveConfigurationRepository _repository;
        public GoogleDriveConfigurationService(GoogleDriveConfigurationRepository repository)
        {
            _repository = repository;
        }

        public int CreateGoogleDriveConfiguration(GoogleDriveConfiguration config)
        {
            return _repository.Create(config);
        }

        public GoogleDriveConfiguration ReadGoogleDriveConfiguration(int id)
        {
            return _repository.Read(id);
        }

        public void UpdateGoogleDriveConfiguration(GoogleDriveConfiguration config)
        {
            _repository.Update(config);
        }

        public void DeleteGoogleDriveConfiguration(int id)
        {
            _repository.Delete(id);
        }
    }
}