using System;

namespace WpfTools
{
    public static class Extensions
    {
        public static void Bind(this Notifier viewModel, string propertyName, Action changeAction)
        {
            viewModel.PropertyChanged += (p, e) =>
            {
                if (e.PropertyName == propertyName) changeAction();
            };
        }
        public static void Bind<T>(this T viewModel, string propertyName, Action<T> changeAction) where T:Notifier
        {
            viewModel.PropertyChanged += (p, e) =>
            {
                if (e.PropertyName == propertyName) changeAction(viewModel);
            };
        }
    }
}
