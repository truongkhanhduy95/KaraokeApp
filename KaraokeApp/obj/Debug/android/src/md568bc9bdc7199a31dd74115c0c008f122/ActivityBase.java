package md568bc9bdc7199a31dd74115c0c008f122;


public class ActivityBase
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onResume:()V:GetOnResumeHandler\n" +
			"";
		mono.android.Runtime.register ("GalaSoft.MvvmLight.Views.ActivityBase, GalaSoft.MvvmLight.Platform, Version=5.4.0.0, Culture=neutral, PublicKeyToken=null", ActivityBase.class, __md_methods);
	}


	public ActivityBase () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActivityBase.class)
			mono.android.TypeManager.Activate ("GalaSoft.MvvmLight.Views.ActivityBase, GalaSoft.MvvmLight.Platform, Version=5.4.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
