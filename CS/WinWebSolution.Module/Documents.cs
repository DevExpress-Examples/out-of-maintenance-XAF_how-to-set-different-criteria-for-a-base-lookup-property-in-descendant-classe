using System;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    [System.ComponentModel.DisplayName("Documents")]
    [DefaultProperty("Name")]
    public abstract class DocumentBase : Note {
        protected const string AssignedToContactCriteriaBase = "Active=True";
        public DocumentBase(Session session) : base(session) { }
        private string nameCore;
        public string Name {
            get { return nameCore; }
            set { SetPropertyValue("Name", ref nameCore, value); }
        }
        private ContactBase createdByCore;
        [DataSourceCriteria(AssignedToContactCriteriaBase)]
        public ContactBase CreatedBy {
            get { return createdByCore; }
            set { SetPropertyValue("CreatedBy", ref createdByCore, value); }
        }
        private ContactBase modifiedByCore;
        [DataSourceProperty("ModifiedByCustomLookupDataSource")]
        public ContactBase ModifiedBy {
            get { return modifiedByCore; }
            set { SetPropertyValue("ModifiedBy", ref modifiedByCore, value); }
        }
        private XPCollection<ContactBase> modifiedByCustomLookupDataSourceCore;
        protected XPCollection<ContactBase> ModifiedByCustomLookupDataSource {
            get {
                if (modifiedByCustomLookupDataSourceCore == null) {
                    modifiedByCustomLookupDataSourceCore = new XPCollection<ContactBase>(Session);
                }
                RefreshModifiedByCustomLookupDataSource();
                return modifiedByCustomLookupDataSourceCore;
            }
        }
        protected virtual void RefreshModifiedByCustomLookupDataSource() {
            modifiedByCustomLookupDataSourceCore.Criteria = ModifiedByContactCriteria;
        }
        protected abstract CriteriaOperator ModifiedByContactCriteria { get;}
    }
    public class DocumentType1 : DocumentBase {
        protected const string AssignedToContactCriteria1 = "ObjectType.TypeName='WinWebSolution.Module.ContactType1'";
        public DocumentType1(Session session) : base(session) { }
        private string documentType1PropertyCore;
        public string DocumentType1Property {
            get { return documentType1PropertyCore; }
            set { SetPropertyValue("DocumentType1Property", ref documentType1PropertyCore, value); }
        }
        [DataSourceCriteria(AssignedToContactCriteriaBase + " AND " + AssignedToContactCriteria1)]
        public new ContactBase CreatedBy {
            get { return base.CreatedBy; }
            set { base.CreatedBy = value; }
        }
        protected override CriteriaOperator ModifiedByContactCriteria {
            get { return CriteriaOperator.Parse(String.Format("{0} AND {1}", AssignedToContactCriteriaBase, AssignedToContactCriteria1)); }
        }
    }
    public class DocumentType2 : DocumentBase {
        protected const string AssignedToContactCriteria2 = "ObjectType.TypeName='WinWebSolution.Module.ContactType2'";
        public DocumentType2(Session session) : base(session) { }
        private string documentType2PropertyCore;
        public string DocumentType2Property {
            get { return documentType2PropertyCore; }
            set { SetPropertyValue("DocumentType2Property", ref documentType2PropertyCore, value); }
        }
        [DataSourceCriteria(AssignedToContactCriteriaBase + " AND " + AssignedToContactCriteria2)]
        public new ContactBase CreatedBy {
            get { return base.CreatedBy; }
            set { base.CreatedBy = value; }
        }
        protected override CriteriaOperator ModifiedByContactCriteria {
            get { return CriteriaOperator.Parse(String.Format("{0} AND {1}", AssignedToContactCriteriaBase, AssignedToContactCriteria2)); }
        }
    }
}