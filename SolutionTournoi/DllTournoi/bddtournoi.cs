using BddtournoiContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllTournoi
{
    public class bddtournoi
    {

        private BddtournoiDataContext bdd = null;
        public bddtournoi()
        {
            try
            {
                bdd = new BddtournoiDataContext();
            }
            catch
            {
                throw;
            }
        }
        public bddtournoi(string serveurIp, string port, string user, string mdp)
        {
            try
            {
                bdd = new BddtournoiDataContext("User Id=" + user + ";Password=" + mdp + ";Host=" + serveurIp + ";Port=" + port + ";Database=bddpersonnels;Persist Security Info=True");
            }
            catch
            {
                throw;
            }
        }

        public List<Sport> getallSports()
        {
            try
            {
                return bdd.Sports.ToList();
            }
            catch { throw; }
        }
        public List<Tournoi> getallTournois()
        {
            try
            {
                return bdd.Tournois.ToList();
            }
            catch { throw; }
        }
        public List<Participant> getallParticipants()
        {
            try
            {
                return bdd.Participants.ToList();
            }
            catch { throw; }
        }
        public List<Participant> getParticipantsPourTournoi(Tournoi tournoi)
        {           
            List<Participant> participantsT= new List<Participant>();
            try
            {
                foreach (Participant par in bdd.Participants)
                {
                    if (par.IdTournoi == tournoi.IdTournoi)
                        participantsT.Add(par);
                }
                return participantsT;
            }catch { throw; }
        }
        public List<Participant> getParticipantsPourSport(Sport sport)
        {
            Participant participant = new Participant();
            List<Participant> participantsS = new List<Participant>();
            try
            {
                foreach (Participant par in bdd.Participants)
                {
                    if (par.IdSport == sport.IdSport)
                        participantsS.Add(par);
                }
                return participantsS;
            }
            catch { throw; }
        }
        public bool AjoutSport(string NSport)
        {
            bool result;
            try
            {
                Sport sp = new Sport();
                sp.Intitule = NSport;
                bdd.Sports.InsertOnSubmit(sp);
                bdd.SubmitChanges();
                result = true;
                return result;
            }
            catch { throw; }
        }
        public bool AjoutTournoi(string NTournoi)
        {
            bool result;
            try
            {
                Tournoi sp = new Tournoi();
                sp.Intitule = NTournoi;
                bdd.Tournois.InsertOnSubmit(sp);
                bdd.SubmitChanges();
                result = true;
                return result;
            }
            catch { throw; }
        }
    }
}
