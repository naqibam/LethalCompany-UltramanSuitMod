using ModelReplacement;
using UnityEngine;

namespace ModelReplacement
{
    public class ULTRAMAN : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "ULTRAMAN";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
	public class ULTRASEVEN : BodyReplacementBase
	{
		protected override GameObject LoadAssetsAndReturnModel()
		{
			string model_name = "Ultraseven";
			return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
		}
	}
	public class MEBIUS : BodyReplacementBase
	{
		protected override GameObject LoadAssetsAndReturnModel()
		{
			string model_name = "mebius";
			return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
		}
	}
	public class TIGA : BodyReplacementBase
	{
		protected override GameObject LoadAssetsAndReturnModel()
		{
			string model_name = "Tiga";
			return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
		}
	}
	public class DYNA : BodyReplacementBase
	{
		protected override GameObject LoadAssetsAndReturnModel()
		{
			string model_name = "Dyna";
			return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
		}
	}
	public class GAIA : BodyReplacementBase
	{
		protected override GameObject LoadAssetsAndReturnModel()
		{
			string model_name = "Gaia";
			return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
		}
	}
}