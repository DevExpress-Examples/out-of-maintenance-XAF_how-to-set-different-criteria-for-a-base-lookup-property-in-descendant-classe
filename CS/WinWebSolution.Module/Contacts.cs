using System;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    [System.ComponentModel.DisplayName("Contacts")]
    public abstract class ContactBase : Person {
        public ContactBase(Session session) : base(session) { }
        private bool activeCore;
        public bool Active {
            get { return activeCore; }
            set { SetPropertyValue("Active", ref activeCore, value); }
        }
    }
    public class ContactType1 : ContactBase {
        public ContactType1(Session session) : base(session) { }
        private string contactType1PropertyCore;
        public string ContactType1Property {
            get { return contactType1PropertyCore; }
            set { SetPropertyValue("ContactType1Property", ref contactType1PropertyCore, value); }
        }
    }
    public class ContactType2 : ContactBase {
        public ContactType2(Session session) : base(session) { }
        private string contactType2PropertyCore;
        public string ContactType2Property {
            get { return contactType2PropertyCore; }
            set { SetPropertyValue("ContactType2Property", ref contactType2PropertyCore, value); }
        }
    }
}