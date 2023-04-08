using SEDC.TryBeingFit.Domain.Database;
using SEDC.TryBeingFit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Services
{
    public class VideoTrainingService
    {
        private Database<VideoTraining> _database;
        public List<VideoTraining> GetAllVideoTrainings()
        {
            //TODO
            return _database.GetAll();
        }
    }
}
