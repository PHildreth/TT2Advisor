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
            //Toto = new Toto(petLevels.Toto);
            //Cerberus = new Cerberus(petLevels.Cerberus);
            //Mousy = new Mousy(petLevels.Mousy);
            //Harker = new Harker(petLevels.Harker);
            //Bubbles = new Bubbles(petLevels.Bubbles);
            //Demos = new Demos(petLevels.Demos);
            //Tempest = new Tempest(petLevels.Tempest);
            //Basky = new Basky(petLevels.Basky);
            //Scraps = new Scraps(petLevels.Scraps);
            //Zero = new Zero(petLevels.Zero);
            //Polly = new Polly(petLevels.Polly);
            //Hamy = new Hamy(petLevels.Hamy);
            //Phobos = new Phobos(petLevels.Phobos);
            //Fluffers = new Fluffers(petLevels.Fluffers);
            //Kit = new Kit(petLevels.Kit);
            //Soot = new Soot(petLevels.Soot);
            //Klack = new Klack(petLevels.Klack);
            //Cooper = new Cooper(petLevels.Cooper);
            //Jaws = new Jaws(petLevels.Jaws);
            //Xander = new Xander(petLevels.Xander);
            //Griff = new Griff(petLevels.Griff);
            //Basil = new Basil(petLevels.Basil);
            //Bash = new Bash(petLevels.Bash);
            //Violet = new Violet(petLevels.Violet);
            //Annabelle = new Annabelle(petLevels.Annabelle);
            //Effie = new Effie(petLevels.Effie);
            //Percy = new Percy(petLevels.Percy);
            //Cosmos = new Cosmos(petLevels.Cosmos);
            //Taffy = new Taffy(petLevels.Taffy);

        }

        public IPet Nova { get; set; }
        public IPet Toto { get; set; }
        public IPet Cerberus { get; set; }
        public IPet Mousy { get; set; }
        public IPet Harker { get; set; }
        public IPet Bubbles { get; set; }
        public IPet Demos { get; set; }
        public IPet Tempest { get; set; }
        public IPet Basky { get; set; }
        public IPet Scraps { get; set; }
        public IPet Zero { get; set; }
        public IPet Polly { get; set; }
        public IPet Hamy { get; set; }
        public IPet Phobos { get; set; }
        public IPet Fluffers { get; set; }
        public IPet Kit { get; set; }
        public IPet Soot { get; set; }
        public IPet Klack { get; set; }
        public IPet Cooper { get; set; }
        public IPet Jaws { get; set; }
        public IPet Xander { get; set; }
        public IPet Griff { get; set; }
        public IPet Basil { get; set; }
        public IPet Bash { get; set; }
        public IPet Violet { get; set; }
        public IPet Annabelle { get; set; }
        public IPet Effie { get; set; }
        public IPet Percy { get; set; }
        public IPet Cosmos { get; set; }
        public IPet Taffy { get; set; }

    }
}
