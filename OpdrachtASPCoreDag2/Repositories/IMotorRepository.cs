using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpdrachtASPCoreDag2.Models;

namespace OpdrachtASPCoreDag2.Repositories
{
    public interface IMotorRepository
    {
        public List<MotorModel> GetMotoren();
        public void VoegMotorToe(MotorModel mModel);
    }
}
