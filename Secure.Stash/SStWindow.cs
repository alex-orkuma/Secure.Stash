using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure.Stash
{
    public class SStWindow : Window
    {
        public SStWindow() : base() { }
        public SStWindow(Page page) : base(page) { }

        protected override void OnCreated()
        {
            Debug.WriteLine("Secure.Stash.App: 1. OnCreated");
        }
        protected override void OnActivated()
        {
            Debug.WriteLine("Secure.Stash.App: 2. OnActivated");
        }
        protected override void OnDeactivated()
        {
            Debug.WriteLine("Secure.Stash.App: 2. OnDeactivated");
        }
        protected override void OnStopped()
        {
            Debug.WriteLine("Secure.Stash.App: 2. OnStopped");
        }
        protected override void OnResumed()
        {
            Debug.WriteLine("Secure.Stash.App: 2. OnResumed");
        }
        protected override void OnDestroying()
        {
            Debug.WriteLine("Secure.Stash.App: 2. OnDestroying");
        }
        

    }
}
