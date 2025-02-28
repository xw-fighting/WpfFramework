﻿using System.Collections.Generic;
using System.Windows;
using PropertyChanged;

namespace MyWpfFramework.Common.UI
{
    /// <summary>
    /// اطلاعات آلرت باکس برنامه
    /// </summary>
    [ImplementPropertyChanged] // AOP
    public class AlertConfirmBoxModel
    {
        /// <summary>
        /// وضعیت جاری
        /// </summary>
        public string CurrentState { set; get; }

        /// <summary>
        /// لیست خطاهایی که باید نمایش دهد
        /// </summary>
        public List<string> Errors { set; get; }

        /// <summary>
        /// عنوان آلرت باکس
        /// </summary>
        public string ErrorTitle { set; get; }

        /// <summary>
        /// نمایان شود
        /// </summary>
        public Visibility IsVisible { set; get; }

        /// <summary>
        /// دکمه لغو نمایش داده شود؟
        /// </summary>
        public Visibility ShowCancel { set; get; }

        /// <summary>
        /// دکمه تائید نمایش داده شود؟
        /// </summary>
        public Visibility ShowConfirm { set; get; }

        /// <summary>
        /// سازنده کلاس اطلاعات آلرت باکس برنامه
        /// </summary>
        public AlertConfirmBoxModel()
        {
            // مقادیر پیش فرض
            ShowCancel = Visibility.Collapsed;
            ShowConfirm = Visibility.Visible;
        }
    }
}