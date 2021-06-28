using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Common.Enums;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.Pets
{
    public class PetsRepo
    {

        public class Nova : IPet
        {
            public Nova(int level)
            {
                Level = level;
            }

            public string Name => "Nova";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Nova;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Toto : IPet
        {
            public Toto(int level)
            {
                Level = level;
            }

            public string Name => "Toto";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Toto;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Cerberus : IPet
        {
            public Cerberus(int level)
            {
                Level = level;
            }

            public string Name => "Cerberus";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Cerberus;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Mousy : IPet
        {
            public Mousy(int level)
            {
                Level = level;
            }

            public string Name => "Mousy";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Mousy;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Harker : IPet
        {
            public Harker(int level)
            {
                Level = level;
            }

            public string Name => "Harker";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Harker;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Bubbles : IPet
        {
            public Bubbles(int level)
            {
                Level = level;
            }

            public string Name => "Bubbles";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Bubbles;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Demos : IPet
        {
            public Demos(int level)
            {
                Level = level;
            }

            public string Name => "Demos";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Demos;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Tempest : IPet
        {
            public Tempest(int level)
            {
                Level = level;
            }

            public string Name => "Tempest";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Tempest;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Basky : IPet
        {
            public Basky(int level)
            {
                Level = level;
            }

            public string Name => "Basky";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Basky;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Scraps : IPet
        {
            public Scraps(int level)
            {
                Level = level;
            }

            public string Name => "Scraps";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Scraps;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Zero : IPet
        {
            public Zero(int level)
            {
                Level = level;
            }

            public string Name => "Zero";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Zero;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Polly : IPet
        {
            public Polly(int level)
            {
                Level = level;
            }

            public string Name => "Polly";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Polly;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Hamy : IPet
        {
            public Hamy(int level)
            {
                Level = level;
            }

            public string Name => "Hamy";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Hamy;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Phobos : IPet
        {
            public Phobos(int level)
            {
                Level = level;
            }

            public string Name => "Phobos";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Phobos;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Fluffers : IPet
        {
            public Fluffers(int level)
            {
                Level = level;
            }

            public string Name => "Fluffers";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Fluffers;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Kit : IPet
        {
            public Kit(int level)
            {
                Level = level;
            }

            public string Name => "Kit";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Kit;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Soot : IPet
        {
            public Soot(int level)
            {
                Level = level;
            }

            public string Name => "Soot";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Soot;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Klack : IPet
        {
            public Klack(int level)
            {
                Level = level;
            }

            public string Name => "Klack";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Klack;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Cooper : IPet
        {
            public Cooper(int level)
            {
                Level = level;
            }

            public string Name => "Cooper";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Cooper;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Jaws : IPet
        {
            public Jaws(int level)
            {
                Level = level;
            }

            public string Name => "Jaws";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Jaws;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Xander : IPet
        {
            public Xander(int level)
            {
                Level = level;
            }

            public string Name => "Xander";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Xander;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Griff : IPet
        {
            public Griff(int level)
            {
                Level = level;
            }

            public string Name => "Griff";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Griff;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Basil : IPet
        {
            public Basil(int level)
            {
                Level = level;
            }

            public string Name => "Basil";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Basil;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Bash : IPet
        {
            public Bash(int level)
            {
                Level = level;
            }

            public string Name => "Bash";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Bash;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Violet : IPet
        {
            public Violet(int level)
            {
                Level = level;
            }

            public string Name => "Violet";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Violet;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Annabelle : IPet
        {
            public Annabelle(int level)
            {
                Level = level;
            }

            public string Name => "Annabelle";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Annabelle;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Effie : IPet
        {
            public Effie(int level)
            {
                Level = level;
            }

            public string Name => "Effie";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Effie;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Percy : IPet
        {
            public Percy(int level)
            {
                Level = level;
            }

            public string Name => "Percy";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Percy;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Cosmos : IPet
        {
            public Cosmos(int level)
            {
                Level = level;
            }

            public string Name => "Cosmos";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Cosmos;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

        public class Taffy : IPet
        {
            public Taffy(int level)
            {
                Level = level;
            }

            public string Name => "Taffy";

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Taffy;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }

    }
}
