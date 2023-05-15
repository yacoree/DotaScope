namespace DotaScope.Data
{
    public class SingletonDotaApi
    {
        DotaAPI dotaAPI;

        public SingletonDotaApi()
        {
            this.dotaAPI = new DotaAPI("170B3F92C5C2F9C7A2D8BC7DC3FB97F7");
        }

        public DotaAPI GetDotaAPI()
        {
            return dotaAPI;
        }

        public void SetDotaAPI(DotaAPI dotaAPI)
        {
            this.dotaAPI = dotaAPI;
        }
    }
}
