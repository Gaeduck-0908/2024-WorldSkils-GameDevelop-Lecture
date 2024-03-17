using UnityEngine;

//���ӽ����̽�
namespace lib
{
    //�̱��� ������ ����
    /*
    1. ���� �ý��ۿ���?��ü�� �����ϴ� ��ũ��Ʈ(����?�ý��� �ڿ� ���� ����)
    2. ���� �ý��ۻ� ���� ������ ������ �ϴ� ��ũ��Ʈ
    3. �� �ε��?�����Ͱ� �ı����� �ʰ�?����
    4. ���� ������Ʈ�� ������ �ؾ� �ϴ� ��ũ��Ʈ�� ����
    5. �� �Ѱ��� ��ü�� ����
    */

    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour //���׸� T ���� ���� MonoBehaviour
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                _instance = FindObjectOfType(typeof(T)) as T;

                if (_instance == null)
                {
                    _instance = new GameObject(typeof(T).ToString()).AddComponent<T>();
                    DontDestroyOnLoad(_instance.gameObject);
                }

                return _instance;
            }
        }
    }
}