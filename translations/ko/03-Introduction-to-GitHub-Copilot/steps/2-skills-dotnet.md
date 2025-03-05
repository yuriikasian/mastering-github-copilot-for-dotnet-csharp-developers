## 2단계: C# 파일에서 Seeing AI 코드 제안 확인하기!

_잘하셨습니다! :tada: Copilot이 설치된 devcontainer 파일을 사용하여 Codespace를 생성하셨네요!_

GitHub Copilot은 다양한 언어와 프레임워크에 대해 제안을 제공하지만, 특히 Python, JavaScript, TypeScript, Ruby, Go, C#, C++에서 잘 작동합니다. 아래 샘플은 C#을 사용하지만, 다른 언어에서도 유사하게 작동합니다.

이제 Copilot을 활용하여 C#을 사용해 봅시다.

> **Note**:
> 위에서 Codespace를 닫았다면 다시 열거나 새 Codespace를 생성하세요.

### ⌨️ 활동: C# 파일 추가 및 코드 작성 시작

> **Note**:
> **Solution Explorer**를 열어 정리된 뷰를 확인하고 새 프로젝트를 쉽게 추가하거나 실행하세요.

1. `.NET: New Project...` 명령을 사용하고 `Console App`를 선택하여 새 .NET 프로젝트를 생성합니다.  
1. **code** 폴더를 선택하고 프로젝트 이름을 **Skills**로 지정합니다.  
1. `Program.cs`를 엽니다.  
1. 새 파일이 다음과 같이 보이는지 확인합니다:  
   ![VS code with a new Program.cs](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-0.png)  

1. `Program.cs` 파일에서 모든 코드를 제거한 뒤, 아래 함수 헤더를 입력합니다.

   ```csharp
   void CalculateNumbers(int var1, int var2)
   {
   ```

   GitHub Copilot은 자동으로 전체 함수 본문을 회색 텍스트로 제안합니다. 아래는 예상되는 예제이며, 정확한 제안 내용은 다를 수 있습니다.  
   ![VS Code with completions](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-dotnet-1.png)

5. `Tab` 키를 눌러 제안을 수락하세요.

### ⌨️ 활동: Codespace에서 코드 저장소로 푸시하기

GitHub Copilot을 사용하여 변경 사항을 요약하고 코드를 커밋해 봅시다.

1. **Source Control** 탭을 엽니다.  
2. Copilot이 메시지를 생성하도록 **Message** 입력창에서 ✨ 버튼을 누릅니다.  

![Commit tab open to generate message with Copilot](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. **Commit** 버튼을 클릭합니다.

[연습 3단계로 이동하기](./3-copilot-hub.md)

**면책 조항**:  
이 문서는 AI 기반 기계 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 최선을 다하고 있으나, 자동 번역에는 오류나 부정확성이 포함될 수 있습니다. 원문이 작성된 언어의 문서를 신뢰할 수 있는 권위 있는 자료로 간주해야 합니다. 중요한 정보의 경우, 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.