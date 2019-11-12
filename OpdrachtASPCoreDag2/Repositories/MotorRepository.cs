using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpdrachtASPCoreDag2.Models;

namespace OpdrachtASPCoreDag2.Repositories
{
    public class MotorRepository : IMotorRepository
    {
        private readonly Opdracht1coredag2Context context;

        public MotorRepository(Opdracht1coredag2Context context) {
            this.context = context;
        }

        public List<MotorModel> GetMotoren() {
            return context.Motor.Select(m => new MotorModel {
                Id = m.Id,
                Merk = m.Merk,
                Type = m.Type,
                Prijs = m.Prijs
            }).ToList();
        }
        public void VoegMotorToe(MotorModel mModel) {
            context.Add(new Motor { 
                Merk = mModel.Merk,
                Prijs = 100,
                Type = "Kawasaki"
            });
            context.SaveChanges();
        }
    }
}
