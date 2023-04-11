using Syncfusion.Maui.DataForm;

namespace EditableComboBoxEditor
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        private SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("dataForm");
            if (dataForm != null)
            {
                dataForm.ItemsSourceProvider = new ItemSourceProvider();
                dataForm.RegisterEditor("Country", DataFormEditorType.ComboBox);
                dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
            }
        }

        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
            {
                comboBoxItem.IsEditable = true;
            }
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.dataForm != null)
            {
                dataForm.GenerateDataFormItem -= this.OnGenerateDataFormItem;
            }
        }
    }
}