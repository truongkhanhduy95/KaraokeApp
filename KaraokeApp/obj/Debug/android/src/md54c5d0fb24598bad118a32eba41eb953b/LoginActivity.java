package md54c5d0fb24598bad118a32eba41eb953b;


public class LoginActivity
	extends md568bc9bdc7199a31dd74115c0c008f122.ActivityBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("KaraokeApp.LoginActivity, KaraokeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LoginActivity.class, __md_methods);
	}


	public LoginActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LoginActivity.class)
			mono.android.TypeManager.Activate ("KaraokeApp.LoginActivity, KaraokeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
