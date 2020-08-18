
namespace MySQLConnector
{

class Session
{
public:
    Session(const char* host, const char* user, const char* pass);
    ~Session();
    int NumConnections();
private:
    class RawSession* raw_session;
};

}
