using System;


namespace Hanselman1.Portable
{
    public interface ITweetStore
    {
        void Save(System.Collections.Generic.List<Hanselman1.Portable.Tweet> tweets);
        //System.Collections.Generic.List<Hanselman1.Shared.Tweet> Load ();
    }
}

