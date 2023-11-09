
#include <iostream>
using namespace std;

template<typename Timing>
class TimeHrMn {
public:
    void SetTime(int userMin);
    void PrintTime() const;
private:
    Timing hrsVal;
    Timing minsVal;
};

template<typename Timing>
void TimeHrMn<Timing>::SetTime(int userMin) {
    minsVal = userMin;
    hrsVal = userMin / 60.0;
}

template<typename Timing>
void TimeHrMn<Timing>::PrintTime() const {
    cout << "Hours: " << hrsVal << " ";
    cout << "Minutes: " << minsVal << endl;
}

int main() {
    TimeHrMn<int> usrTimeInt;
    TimeHrMn<double> usrTimeDbl;

    usrTimeInt.SetTime(135);
    usrTimeInt.PrintTime();

    usrTimeDbl.SetTime(135.0);
    usrTimeDbl.PrintTime();

    return 0;
}
