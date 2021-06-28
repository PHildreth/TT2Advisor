using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Pets;
using TT2Advisor.Import;
using static TT2Advisor.Pets.PetsRepo;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.PlayerBuild
{
    public class PetLevels
    {
        //public PetLevels(JToken petLevelsToken)
        //{
        //    Nova = new Pet<Nova>(petLevelsToken.SelectToken("Nova"));
        //}

        public PetLevels(Import.PetLevels petLevels)
        {
            Nova = new Nova(petLevels.Nova);
            Toto = new Toto(petLevels.Toto);
            Cerberus = new Cerberus(petLevels.Cerberus);
            Mousy = new Mousy(petLevels.Mousy);
            Harker = new Harker(petLevels.Harker);
            Bubbles = new Bubbles(petLevels.Bubbles);
            Demos = new Demos(petLevels.Demos);
            Tempest = new Tempest(petLevels.Tempest);
            Basky = new Basky(petLevels.Basky);
            Scraps = new Scraps(petLevels.Scraps);
            Zero = new Zero(petLevels.Zero);
            Polly = new Polly(petLevels.Polly);
            Hamy = new Hamy(petLevels.Hamy);
            Phobos = new Phobos(petLevels.Phobos);
            Fluffers = new Fluffers(petLevels.Fluffers);
            Kit = new Kit(petLevels.Kit);
            Soot = new Soot(petLevels.Soot);
            Klack = new Klack(petLevels.Klack);
            Cooper = new Cooper(petLevels.Cooper);
            Jaws = new Jaws(petLevels.Jaws);
            Xander = new Xander(petLevels.Xander);
            Griff = new Griff(petLevels.Griff);
            Basil = new Basil(petLevels.Basil);
            Bash = new Bash(petLevels.Bash);
            Violet = new Violet(petLevels.Violet);
            Annabelle = new Annabelle(petLevels.Annabelle);
            Effie = new Effie(petLevels.Effie);
            Percy = new Percy(petLevels.Percy);
            Cosmos = new Cosmos(petLevels.Cosmos);
            Taffy = new Taffy(petLevels.Taffy);

        }

        public Nova Nova { get; set; }
        public Toto Toto { get; set; }
        public Cerberus Cerberus { get; set; }
        public Mousy Mousy { get; set; }
        public Harker Harker { get; set; }
        public Bubbles Bubbles { get; set; }
        public Demos Demos { get; set; }
        public Tempest Tempest { get; set; }
        public Basky Basky { get; set; }
        public Scraps Scraps { get; set; }
        public Zero Zero { get; set; }
        public Polly Polly { get; set; }
        public Hamy Hamy { get; set; }
        public Phobos Phobos { get; set; }
        public Fluffers Fluffers { get; set; }
        public Kit Kit { get; set; }
        public Soot Soot { get; set; }
        public Klack Klack { get; set; }
        public Cooper Cooper { get; set; }
        public Jaws Jaws { get; set; }
        public Xander Xander { get; set; }
        public Griff Griff { get; set; }
        public Basil Basil { get; set; }
        public Bash Bash { get; set; }
        public Violet Violet { get; set; }
        public Annabelle Annabelle { get; set; }
        public Effie Effie { get; set; }
        public Percy Percy { get; set; }
        public Cosmos Cosmos { get; set; }
        public Taffy Taffy { get; set; }
    }
}
