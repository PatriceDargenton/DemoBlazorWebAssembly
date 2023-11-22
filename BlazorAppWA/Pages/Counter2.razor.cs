using Microsoft.AspNetCore.Components;

namespace BlazorAppWA.Pages
{
    public class Counter2Base: ComponentBase
    {
        protected int currentCount = 0;
        
        [Parameter]
        public int Value { get => currentCount; set => currentCount = value; }

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
