using Microsoft.AspNetCore.Identity;
using myScoreApp.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.Models
{
    public interface IDepo
    {
        void MekanEkle(Mekan mekan);
        Mekan MekanGetir(int id);
        List<Mekan> TumMekanlar();
        void MekanSil(int id);
        void YorumSil(int id);
        MainComment YorumGetir(int id);
        SubComment AltYorumGetir(int id);
        void AltYorumSil(int id);
        void MekanGuncelle(int id, Mekan mekan);
        void YorumEkle(Mekan mekan);
        List<Mekan> BenimMekanlar(IdentityUser user);
        void AltYorumEkle(SubComment comment);
        Task<bool> SaveChangesAsync();
    }
}
