/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OpenTransactions.OTAPI {

public class otapi {
  public static bool InitDefaultStorage(StorageType eStoreType, PackType ePackType) {
    bool ret = otapiPINVOKE.InitDefaultStorage((int)eStoreType, (int)ePackType);
    return ret;
  }

  public static Storage GetDefaultStorage() {
    global::System.IntPtr cPtr = otapiPINVOKE.GetDefaultStorage();
    Storage ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storage(cPtr, false);
    return ret;
  }

  public static Storage CreateStorageContext(StorageType eStoreType, PackType ePackType) {
    global::System.IntPtr cPtr = otapiPINVOKE.CreateStorageContext__SWIG_0((int)eStoreType, (int)ePackType);
    Storage ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storage(cPtr, true);
    return ret;
  }

  public static Storage CreateStorageContext(StorageType eStoreType) {
    global::System.IntPtr cPtr = otapiPINVOKE.CreateStorageContext__SWIG_1((int)eStoreType);
    Storage ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storage(cPtr, true);
    return ret;
  }

  public static Storable CreateObject(StoredObjectType eType) {
    global::System.IntPtr cPtr = otapiPINVOKE.CreateObject((int)eType);
    Storable ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storable(cPtr, true);
    return ret;
  }

  public static bool CheckStringsExistInOrder(SWIGTYPE_p_std__string strFolder, SWIGTYPE_p_std__string oneStr, SWIGTYPE_p_std__string twoStr, SWIGTYPE_p_std__string threeStr, string szFuncName) {
    bool ret = otapiPINVOKE.CheckStringsExistInOrder__SWIG_0(SWIGTYPE_p_std__string.getCPtr(strFolder), SWIGTYPE_p_std__string.getCPtr(oneStr), SWIGTYPE_p_std__string.getCPtr(twoStr), SWIGTYPE_p_std__string.getCPtr(threeStr), szFuncName);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool CheckStringsExistInOrder(SWIGTYPE_p_std__string strFolder, SWIGTYPE_p_std__string oneStr, SWIGTYPE_p_std__string twoStr, SWIGTYPE_p_std__string threeStr) {
    bool ret = otapiPINVOKE.CheckStringsExistInOrder__SWIG_1(SWIGTYPE_p_std__string.getCPtr(strFolder), SWIGTYPE_p_std__string.getCPtr(oneStr), SWIGTYPE_p_std__string.getCPtr(twoStr), SWIGTYPE_p_std__string.getCPtr(threeStr));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Exists(string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.Exists__SWIG_0(strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Exists(string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.Exists__SWIG_1(strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Exists(string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.Exists__SWIG_2(strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Exists(string strFolder) {
    bool ret = otapiPINVOKE.Exists__SWIG_3(strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StoreString(string strContents, string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.StoreString__SWIG_0(strContents, strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StoreString(string strContents, string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.StoreString__SWIG_1(strContents, strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StoreString(string strContents, string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.StoreString__SWIG_2(strContents, strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StoreString(string strContents, string strFolder) {
    bool ret = otapiPINVOKE.StoreString__SWIG_3(strContents, strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string QueryString(string strFolder, string oneStr, string twoStr, string threeStr) {
    string ret = otapiPINVOKE.QueryString__SWIG_0(strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string QueryString(string strFolder, string oneStr, string twoStr) {
    string ret = otapiPINVOKE.QueryString__SWIG_1(strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string QueryString(string strFolder, string oneStr) {
    string ret = otapiPINVOKE.QueryString__SWIG_2(strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string QueryString(string strFolder) {
    string ret = otapiPINVOKE.QueryString__SWIG_3(strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StorePlainString(string strContents, string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.StorePlainString__SWIG_0(strContents, strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StorePlainString(string strContents, string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.StorePlainString__SWIG_1(strContents, strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StorePlainString(string strContents, string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.StorePlainString__SWIG_2(strContents, strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StorePlainString(string strContents, string strFolder) {
    bool ret = otapiPINVOKE.StorePlainString__SWIG_3(strContents, strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string QueryPlainString(string strFolder, string oneStr, string twoStr, string threeStr) {
    string ret = otapiPINVOKE.QueryPlainString__SWIG_0(strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string QueryPlainString(string strFolder, string oneStr, string twoStr) {
    string ret = otapiPINVOKE.QueryPlainString__SWIG_1(strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string QueryPlainString(string strFolder, string oneStr) {
    string ret = otapiPINVOKE.QueryPlainString__SWIG_2(strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string QueryPlainString(string strFolder) {
    string ret = otapiPINVOKE.QueryPlainString__SWIG_3(strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StoreObject(Storable theContents, string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.StoreObject__SWIG_0(Storable.getCPtr(theContents), strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StoreObject(Storable theContents, string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.StoreObject__SWIG_1(Storable.getCPtr(theContents), strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StoreObject(Storable theContents, string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.StoreObject__SWIG_2(Storable.getCPtr(theContents), strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool StoreObject(Storable theContents, string strFolder) {
    bool ret = otapiPINVOKE.StoreObject__SWIG_3(Storable.getCPtr(theContents), strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Storable QueryObject(StoredObjectType theObjectType, string strFolder, string oneStr, string twoStr, string threeStr) {
    global::System.IntPtr cPtr = otapiPINVOKE.QueryObject__SWIG_0((int)theObjectType, strFolder, oneStr, twoStr, threeStr);
    Storable ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Storable QueryObject(StoredObjectType theObjectType, string strFolder, string oneStr, string twoStr) {
    global::System.IntPtr cPtr = otapiPINVOKE.QueryObject__SWIG_1((int)theObjectType, strFolder, oneStr, twoStr);
    Storable ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Storable QueryObject(StoredObjectType theObjectType, string strFolder, string oneStr) {
    global::System.IntPtr cPtr = otapiPINVOKE.QueryObject__SWIG_2((int)theObjectType, strFolder, oneStr);
    Storable ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Storable QueryObject(StoredObjectType theObjectType, string strFolder) {
    global::System.IntPtr cPtr = otapiPINVOKE.QueryObject__SWIG_3((int)theObjectType, strFolder);
    Storable ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string EncodeObject(Storable theContents) {
    string ret = otapiPINVOKE.EncodeObject(Storable.getCPtr(theContents));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Storable DecodeObject(StoredObjectType theObjectType, string strInput) {
    global::System.IntPtr cPtr = otapiPINVOKE.DecodeObject((int)theObjectType, strInput);
    Storable ret = (cPtr == global::System.IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EraseValueByKey(string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.EraseValueByKey__SWIG_0(strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EraseValueByKey(string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.EraseValueByKey__SWIG_1(strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EraseValueByKey(string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.EraseValueByKey__SWIG_2(strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool EraseValueByKey(string strFolder) {
    bool ret = otapiPINVOKE.EraseValueByKey__SWIG_3(strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool OT_API_Set_PasswordCallback(OTCaller theCaller) {
    bool ret = otapiPINVOKE.OT_API_Set_PasswordCallback(OTCaller.getCPtr(theCaller));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly string OT_PW_DISPLAY = otapiPINVOKE.OT_PW_DISPLAY_get();
  public static readonly int OTPASSWORD_BLOCKSIZE = otapiPINVOKE.OTPASSWORD_BLOCKSIZE_get();
  public static readonly int OTPASSWORD_MEMSIZE = otapiPINVOKE.OTPASSWORD_MEMSIZE_get();
  public static readonly int OT_LARGE_BLOCKSIZE = otapiPINVOKE.OT_LARGE_BLOCKSIZE_get();
  public static readonly int OT_LARGE_MEMSIZE = otapiPINVOKE.OT_LARGE_MEMSIZE_get();
  public static readonly int OT_DEFAULT_BLOCKSIZE = otapiPINVOKE.OT_DEFAULT_BLOCKSIZE_get();
  public static readonly int OT_DEFAULT_MEMSIZE = otapiPINVOKE.OT_DEFAULT_MEMSIZE_get();
}

}
