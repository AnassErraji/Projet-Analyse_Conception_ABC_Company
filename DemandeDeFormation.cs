using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demande_formation_compagnieABC
{
    public class DemandeDeFormation
    {
        // Attributs
        private int id;
        private string nomEmploye;
        private string titreFormation;
        private string statut;
        private string commentaire;

        // Constructeur
        public DemandeDeFormation(int id, string nomEmploye, string titreFormation)
        {
            this.id = id;
            this.nomEmploye = nomEmploye;
            this.titreFormation = titreFormation;
            this.statut = "En attente"; // Statut initial
        }

        // Getters et Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomEmploye
        {
            get { return nomEmploye; }
            set { nomEmploye = value; }
        }

        public string TitreFormation
        {
            get { return titreFormation; }
            set { titreFormation = value; }
        }

        public string Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        // Méthodes
        public void SoumettreDemande()
        {
            // Logique pour soumettre la demande
            Console.WriteLine($"Demande soumise par {nomEmploye} pour la formation {titreFormation}");
        }

        public void ApprouverDemande(string commentaire)
        {
            this.statut = "Approuvée";
            this.commentaire = commentaire;
            Console.WriteLine($"Demande approuvée : {commentaire}");
        }

        public void RejeterDemande(string commentaire)
        {
            this.statut = "Rejetée";
            this.commentaire = commentaire;
            Console.WriteLine($"Demande rejetée : {commentaire}");
        }

        // Méthode de représentation sous forme de chaîne de caractères
        public override string ToString()
        {
            return $"DemandeDeFormation{{ id={id}, nomEmploye='{nomEmploye}', titreFormation='{titreFormation}', statut='{statut}', commentaire='{commentaire}' }}";
        }

        // Méthode principale pour tester la classe
        public static void Main(string[] args)
        {
            DemandeDeFormation demande = new DemandeDeFormation(1, "Jean Dupont", "Java Avancé");

            demande.SoumettreDemande();
            Console.WriteLine(demande);

            demande.ApprouverDemande("Formation utile pour le projet en cours.");
            Console.WriteLine(demande);

            // Créer une autre demande et la rejeter
            DemandeDeFormation autreDemande = new DemandeDeFormation(2, "Marie Curie", "Gestion de projet");
            autreDemande.SoumettreDemande();
            Console.WriteLine(autreDemande);

            autreDemande.RejeterDemande("Formation non prioritaire actuellement.");
            Console.WriteLine(autreDemande);
        }
    }
}
