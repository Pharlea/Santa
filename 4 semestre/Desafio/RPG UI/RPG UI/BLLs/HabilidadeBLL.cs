using RPG_UI.DAL;
using RPG_UI.Models;
using RPG_UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_UI.BLLs
{
    internal class HabilidadeBLL
    {
        public static async Task<Habilidade> GetHabilidadeAsync(Habilidade habilidade)
        {
            return await HabilidadesDAL.getHabilidadeAsync(habilidade);
        }

        public static async Task<List<Habilidade>> GetHabilidadesAsync()
        {
            return await HabilidadesDAL.getHabilidadesAsync();
        }

        public static async Task deletaHabilidadeAsync(int id)
        {
            await HabilidadesDAL.deletaHabilidadeAsync(id);
        }

        public static async Task<Habilidade> createHabilidadeAsync(HabilidadeViewModel.CreateHabilidade createHabilidade)
        {
            return await HabilidadesDAL.createHabilidadeAsync(createHabilidade);
        }

        public static async Task updateHabilidadeAsync(HabilidadeViewModel.CreateHabilidade updateHabilidade)
        {
            await HabilidadesDAL.updateHabilidadeAsync(updateHabilidade);
        }

        public static async Task<Habilidade> GetHabilidadeByNameAsync(Habilidade habilidade)
        {
            return await HabilidadesDAL.getHabilidadeByNameAsync(habilidade);
        }
    }
}
