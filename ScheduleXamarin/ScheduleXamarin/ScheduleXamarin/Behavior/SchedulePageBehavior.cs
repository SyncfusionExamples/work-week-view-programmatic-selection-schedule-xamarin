using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class SchedulePageBehavior : Behavior<ContentPage>
    {
        SfSchedule schedule;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.schedule = bindable.FindByName<SfSchedule>("schedule");

            // Setting a date and time to select
            schedule.SelectedDate = new DateTime(2017, 10, 04, 10, 0, 0);

            // Setting null value to deselect
            //schedule.SelectedDate = null;
        }
    }
}

       