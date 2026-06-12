using ECommons.EzIpcManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.IPC
{
    internal class GlamourerIPC
    {
        public const string Name = "Glamourer";
        public const string Repo = "https://github.com/Ottermandias/Glamourer";
        public GlamourerIPC() => EzIPC.Init(this, Name, SafeWrapper.AnyException);
        public bool Installed => Utils.HasPlugin(Name);
        [EzIPC] private readonly Func<int, byte, ulong, IReadOnlyList<byte>, uint, ulong, int> _setItem = null!;

        public void SetClownNose()
        {
            _setItem(0, 3, 6117, [0, 0], 0, 0x01);
        }
    }
}
