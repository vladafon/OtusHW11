using System.Text;

namespace OtusHW11.Models.Abstract
{
    /// <summary>
    ///     Живой организм.
    /// </summary>
    public abstract class Organism
    {
        public Organism(string name, List<Organ> organs)
        {
            Name = name;
            Organs = organs;
        }

        /// <summary>
        ///     Общепринятое название.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Список внутренних органов.
        /// </summary>
        public List<Organ> Organs { get; }

        public override string? ToString()
        {
            var sb = new StringBuilder(
                $"Имя: {Name}\n" +
                $"Список органов:\n");

            sb.Append( new string('*', 10 ));
            sb.Append("\n");

            foreach ( var organ in Organs )
            {
                sb.Append( $"{organ.Name}\n" );
            }

            sb.Append(new string('*', 10));
            sb.Append("\n");

            return sb.ToString();
        }
    }
}
