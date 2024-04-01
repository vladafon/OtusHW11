using OtusHW11.Models.Abstract;
using System.Text;

namespace OtusHW11.Models
{
    /// <summary>
    ///     Паукообразное.
    /// </summary>
    public class Arachnid : Animal, IMyClonable<Arachnid>, ICloneable
    {
        public Arachnid(string name,
            List<Organ> organs, 
            int limbsCount, 
            int eyesCount, 
            bool hasTail,
            bool isPoisonous) : base(name, organs, limbsCount, eyesCount, hasTail)
        {
            IsPoisonous = isPoisonous;
        }


        /// <summary>
        ///     Признак ядовитости существа.
        /// </summary>
        public bool IsPoisonous { get; }

        public object Clone()
            => MyClone();

        public Arachnid MyClone()
            => new Arachnid(Name, Organs, LimbsCount, EyesCount, HasTail, IsPoisonous);

        public override string? ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.Append($"Ядовитый?: {IsPoisonous}\n");

            return sb.ToString();
        }
    }
}
