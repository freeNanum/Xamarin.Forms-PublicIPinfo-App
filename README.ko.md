[View English Version](README.md)

# Xamarin.Forms Tizen Galaxy Watch용 공용 IP 정보 기본 프로젝트

이 저장소는 `ipinfo.io` API를 사용하여 공용 IP 주소 정보 및 관련 세부 정보를 가져오고 표시하도록 설계된 Xamarin.Forms 기본 프로젝트입니다. 이 프로젝트는 핵심 크로스 플랫폼 로직을 제공하지만, 특히 Tizen Galaxy Watch 애플리케이션 개발을 위한 **기본 프로젝트** 역할을 하도록 의도되었습니다.

## 기능

*   **공용 IP 정보 검색:** `https://ipinfo.io/json`에서 공용 IP 주소와 도시, 지역, 국가, 위치(위도/경도), 조직(ISP), 우편번호, 시간대와 같은 포괄적인 세부 정보를 가져옵니다.
*   **크로스 플랫폼 코어:** Xamarin.Forms (C# .NET)로 구축되어 다양한 플랫폼으로 확장할 수 있는 UI 및 로직을 위한 공유 코드베이스를 제공합니다.
*   **Tizen Galaxy Watch 준비:** Tizen 기반 Galaxy Watch 장치와 통합하고 배포하기 위한 시작점으로 설계되었습니다.

## 사용된 기술

*   **Xamarin.Forms:** C# 및 .NET으로 네이티브 UI를 구축하기 위한 크로스 플랫폼 UI 툴킷입니다.
*   **C# .NET:** 주요 프로그래밍 언어 및 프레임워크입니다.
*   **HttpClient:** `ipinfo.io` API에 비동기 HTTP 요청을 보내는 데 사용됩니다.
*   **Newtonsoft.Json:** .NET용으로 널리 사용되는 고성능 JSON 프레임워크로, API 응답을 역직렬화하는 데 사용됩니다.
*   **ipinfo.io API:** 공용 IP 정보를 제공하는 외부 서비스입니다.

## 프로젝트 구조

솔루션은 일반적인 Xamarin.Forms 프로젝트로 구성됩니다.

*   `Cross-platform-App/Cross-platform-App/`: 공통 UI(XAML) 및 비즈니스 로직(C#)을 포함하는 핵심 Xamarin.Forms 공유 프로젝트(PCL/Shared Project)입니다. IP 가져오기 및 표시 로직이 여기에 있습니다.
*   `Cross-platform-App/Cross-platform-App.Android/`: Android 장치에 애플리케이션을 배포하기 위한 Android 특정 프로젝트입니다.
*   `Cross-platform-App/Cross-platform-App.iOS/`: iOS 장치에 애플리케이션을 배포하기 위한 iOS 특정 프로젝트입니다.
*   `Cross-platform-App/Cross-platform-App.UWP/`: Windows 장치에 애플리케이션을 배포하기 위한 UWP(Universal Windows Platform) 프로젝트입니다.

Tizen을 대상으로 하려면 일반적으로 이 솔루션에 새 Tizen 프로젝트를 추가해야 합니다.

## 시작하기

### 전제 조건

*   **Visual Studio:** "모바일 개발(.NET 포함)" 워크로드를 사용하여 Visual Studio(Windows 또는 Mac)를 설치합니다.
*   **.NET SDK:** 필요한 .NET SDK가 설치되어 있는지 확인합니다.
*   **Tizen SDK (Tizen 개발용):** 이 프로젝트를 Tizen Galaxy Watch 앱으로 확장할 계획이라면 Tizen SDK 및 Visual Studio Tools for Tizen을 설치해야 합니다.

### 설정 및 빌드

1.  **저장소 복제:**
    ```bash
    git clone https://github.com/freeNanum/Xamarin.Forms-PublicIPinfo-App.git
    cd Xamarin.Forms-PublicIPinfo-App
    ```
2.  **솔루션 열기:**
    Visual Studio에서 `Cross-platform-App/Cross-platform-App.sln` 파일을 엽니다.
3.  **NuGet 패키지 복원:**
    Visual Studio는 필요한 NuGet 패키지를 자동으로 복원해야 합니다. 그렇지 않은 경우 솔루션 탐색기에서 솔루션을 마우스 오른쪽 버튼으로 클릭하고 "NuGet 패키지 복원"을 선택합니다.
4.  **솔루션 빌드:**
    모든 프로젝트가 올바르게 컴파일되는지 확인하기 위해 솔루션을 빌드합니다.

### 에뮬레이터/장치에서 실행 (Android, iOS, UWP)

*   원하는 플랫폼 프로젝트(예: `Cross-platform-App.Android`)를 시작 프로젝트로 설정합니다.
*   Visual Studio 도구 모음에서 에뮬레이터/시뮬레이터 또는 연결된 장치를 선택합니다.
*   애플리케이션을 실행합니다.

### Tizen Galaxy Watch로 확장

이 프로젝트는 핵심 로직을 제공합니다. Tizen Galaxy Watch 애플리케이션을 만들려면:

1.  **새 Tizen 프로젝트 추가:** Visual Studio에서 솔루션을 마우스 오른쪽 버튼으로 클릭하고 `추가` > `새 프로젝트...`를 선택한 다음 "Tizen 웨어러블 앱 (Xamarin.Forms)" 또는 유사한 템플릿을 선택합니다.
2.  **공유 프로젝트 참조:** 새 Tizen 프로젝트가 `Cross-platform-App` 공유 프로젝트를 참조하는지 확인합니다.
3.  **Tizen NuGet 패키지 설치:** Tizen 프로젝트에 `Xamarin.Forms.Platform.Tizen` NuGet 패키지를 설치합니다.
4.  **Xamarin.Forms 초기화:** Tizen 프로젝트의 `MainApplication.cs`(또는 해당 파일)에서 Xamarin.Forms를 초기화하고 공유 프로젝트에서 `App`을 로드합니다.
5.  **Tizen 장치/에뮬레이터에 배포:** Tizen SDK 도구 및 Visual Studio의 Tizen 통합을 사용하여 Tizen Galaxy Watch 에뮬레이터 또는 실제 장치에 애플리케이션을 배포하고 디버그합니다.

## 사용법

애플리케이션이 대상 장치 또는 에뮬레이터에서 실행되면 버튼(`MainPage.xaml`에서 "Get Public IP" 또는 유사하게 레이블 지정됨)을 탭하여 현재 공용 IP 주소 및 관련 정보를 가져오고 표시합니다.

## 기여

기여를 환영합니다! 저장소를 포크하고 변경 사항을 적용한 다음 풀 리퀘스트를 제출해 주십시오.

## 라이선스

이 프로젝트는 [LICENSE](LICENSE) 파일의 조건에 따라 라이선스가 부여됩니다.
