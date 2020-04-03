﻿namespace AquaShop.Models.Aquariums
{
    using System.Linq;
    using System.Text;

    public class SaltwaterAquarium : Aquarium
    {
        private const int CAPACITY = 25;

        public SaltwaterAquarium(string name)
            : base(name, CAPACITY)
        {

        }

        public override string GetInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.Name} ({this.GetType().Name}):");

            string fish = this.Fish.Any()
                ? $"Fish: {string.Join(", ", this.Fish.Select(f => f.Name))}"
                : $"Fish: none";

            stringBuilder.AppendLine(fish);
            stringBuilder.AppendLine($"Decorations: {this.Decorations.Count}");
            stringBuilder.AppendLine($"Comfort: {this.Comfort}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}