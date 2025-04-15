using Syncfusion.Maui.DataForm;

namespace LoadJSONData
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        private SfDataForm? dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("dataForm");
            if (this.dataForm != null)
            {
                this.dataForm.ItemsSourceProvider = new ItemSourceProvider();
                this.dataForm.RegisterEditor("City", DataFormEditorType.ComboBox);
            }
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.dataForm != null)
            {
                this.dataForm = null;
            }
        }
    }
}