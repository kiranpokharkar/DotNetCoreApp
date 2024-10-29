namespace Demo.Services.Http
{
    public interface IHttpService
    {
        /// <summary>
        ///  Send Get Request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public Task<T> GetAsync<T>(string url);

        /// <summary>
        /// Send PostAsync Request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Task<T> PostAsync<T, T1>(string url, T1 data);

    }
}
