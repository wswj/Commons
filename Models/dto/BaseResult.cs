using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangjing.Model
{
    /// <summary>
    /// api接口返回数据
    /// </summary>
    public class BaseResult<T>
    {
        public BaseResult() {

        }

        /// <summary>
        /// 成功返回
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static BaseResult<T> successResult(T data)
        {
            BaseResult<T> baseResult = new BaseResult<T>();
            baseResult.code = 0;
            baseResult.msg = "success";
            baseResult.data = data;
            return baseResult;
        }

        /// <summary>
        /// 失败返回
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static BaseResult<T> failResult(int code , String errorMsg)
        {
            BaseResult<T> baseResult = new BaseResult<T>();
            baseResult.code = code;
            baseResult.msg = errorMsg;
            return baseResult;
        }

        /// <summary>
        /// 失败返回
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static BaseResult<T> failResultWithCustomJson(int code, String errorMsg, String customJson)
        {
            BaseResult<T> baseResult = new BaseResult<T>();
            baseResult.code = code;
            baseResult.msg = errorMsg;
            baseResult.customJson = customJson;
            return baseResult;
        }

        /// <summary>
        /// 状态 0 表示正常，其他表示错误
        /// </summary>
        public int code
        {
            set;
            get;
        }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool success
        {
            get
            {
                if (code == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        public string msg
        {
            set;
            get;
        }

        public T data
        {
            set;
            get;
        }

        /// <summary>
        /// 定制的json
        /// </summary>
        public String customJson
        {
            set;
            get;
        }
    }
}
