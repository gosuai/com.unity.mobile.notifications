using UnityEngine;

namespace Gosu.Dataplatform
{
	public class Event
	{
		AndroidJavaObject ev;
		public Event(AndroidJavaObject ev) {
			this.ev = ev;
		}
		public Event PutParam(string name, int value) {
			this.ev.Call<AndroidJavaObject>("putParam", name, value);
			return this;
		}
		public Event PutParam(string name, string value) {
			this.ev.Call<AndroidJavaObject>("putParam", name, value);
			return this;
		}
		public Event PutParam(string name, double value) {
			this.ev.Call<AndroidJavaObject>("putParam", name, value);
			return this;
		}
		public Event PutParam(string name, bool value) {
			this.ev.Call<AndroidJavaObject>("putParam", name, value);
			return this;
		}
		public void Record() {
            this.ev.Call("record");
		}
	}

    public static class Gdp
    {
        public static Event Event(string name)
        {
            var gdp = new AndroidJavaClass("ai.gosu.dataplatform.sdk.GDP");
            var ev = gdp.CallStatic<AndroidJavaObject>("event", name);
			return new Event(ev);
        }
    }
}