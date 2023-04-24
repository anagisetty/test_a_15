using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using test_a_15.DTO;

namespace test_a_15
{
    public class GoogleDriveConfigurationRepository
    {
        private readonly GoogleDriveConfiguration _config;

        public GoogleDriveConfigurationRepository(GoogleDriveConfiguration config)
        {
            _config = config;
        }

        public int Create()
        {
            // Create a new record in the database
            return 0;
        }

        public GoogleDriveConfiguration Read(int id)
        {
            // Read a record from the database
            return _config;
        }

        public void Update(GoogleDriveConfiguration config)
        {
            // Update the record in the database
        }

        public void Delete(int id)
        {
            // Delete the record from the database
        }
    }
}