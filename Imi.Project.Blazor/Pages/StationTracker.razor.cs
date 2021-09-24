using Imi.Project.Blazor.Extensions;
using Imi.Project.Blazor.Models.Maps;
using Imi.Project.Blazor.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;

namespace Imi.Project.Blazor.Pages
{
    public partial class StationTracker
    {
        #region Fields

        private static Timer apiCallTimer;
        private int timerDelay = 10;

        #endregion Fields

        #region Constructors

        public StationTracker()
        {
        }

        #endregion Constructors

        #region Properties

        [Inject]
        public IZayraLocationService ZayraLocationService { get; set; }

        private List<Marker> Markers { get; set; }

        #endregion Properties

        #region Methods

        public void StartTimer()
        {
            apiCallTimer = new Timer(1000);
            apiCallTimer.Elapsed += CountDownTimerAsync;
            apiCallTimer.Enabled = true;
        }

        protected override async Task OnInitializedAsync()
        {
            Markers = new List<Marker>() { new Marker() { Name = "Loading data..." } };
            StartTimer();
        }

        private async void CountDownTimerAsync(Object source, ElapsedEventArgs e)
        {
            if (timerDelay > 0)
            {
                timerDelay -= 1;
            }
            else
            {
                await GetIssLocationAsync();
                apiCallTimer.Enabled = false;
                StartTimer();
            }
            await InvokeAsync(StateHasChanged);
        }

        private async Task GetIssLocationAsync()
        {
            Markers = new List<Marker>();
            var currentIssLocationObj = await StationTrackerExtensions.GetCurrentIssLocation(ZayraLocationService);
            Markers.Add(currentIssLocationObj);
        }

        #endregion Methods
    }
}