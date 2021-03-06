﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    // Définition d'une personne
    public class Personnes
    {
        // Définition des variables et propriétés qui constitue la classe personnes
        #region Propriétés
        public string Code { get; }
        public string Nom { get; }
        public string Prénom { get; }
        public Métiers Métier { get; }

        #endregion

        #region Constructeur
        // Instancier/créer une nouvelles personne sans pour autant compélter l'ensemble de ses informations
        public Personnes()
        {

        }

        // Instancier/créer une nouvelles personne nécessite de compléter les champs suivants
        public Personnes(string code, string prénom, string nom, Métiers métier)
        {
            Code = code;
            Nom = nom;
            Prénom = prénom;
            Métier = métier;
        }

        #endregion

        #region Méthodes
        /// <summary>
        /// Redéfinition de la fonction ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",Code, Prénom, Nom, Métier.Intitulé);
        }
        #endregion

    }
}
