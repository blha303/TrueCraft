using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Items
{
    public class WheatItem : ItemProvider
    {
        public static readonly short ItemID = 0x128;

        public override short ID { get { return 0x128; } }

        public override string DisplayName { get { return "Wheat"; } }
    }
}