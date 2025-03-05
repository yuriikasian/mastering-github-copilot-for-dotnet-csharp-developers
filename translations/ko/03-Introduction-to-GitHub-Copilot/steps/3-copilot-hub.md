## 3단계: 여러 제안을 포함한 GitHub Copilot 탭 보기

_잘했어요! GitHub Copilot을 사용해 C# 파일에서 AI 코드 제안을 활용했네요. :sparkles:_

Copilot을 계속 사용하다 보면, GitHub Copilot이 제공하는 일부 제안을 원하지 않을 수도 있습니다. GitHub Copilot은 새로운 탭에서 여러 제안을 보여줍니다.

### ⌨️ 활동: 또 다른 C# 메서드를 추가하고 모든 제안 보기

1. Solution Explorer에서 코드스페이스 안에 있는 프로젝트를 오른쪽 클릭하고 새 파일을 만드세요.

> 참고: 위에서 닫은 코드스페이스가 있다면 다시 열거나 새 코드스페이스를 만드세요.

2. **Class**를 선택하고 파일 이름을 `Members.cs`로 지정하세요.
3. `Members.cs` 파일에서 `Member` 클래스 안에 다음 함수를 작성하세요.  
   ```
   public strin
   ```
4. 타이핑을 멈추고 빨간 물결선 위에 마우스를 올려 Copilot 제안을 확인하세요. 그런 다음 `...`
5. Click `Open Completions Panel`. 

   > **Note**
   > If you don't see the copilot code block suggestion or the red squiggly and the three dots `...`, you can type `control + enter` to bring up the GitHub Copilot completions panel.

6. Copilot will synthesize around 10 different code suggestions or press CTRL+Enter. You should see something like this:
   ![VS Code showing pop up with Completions Panel](../../../../03-Introduction-to-GitHub-Copilot/steps/img/3-copilot-hub-0.png)
7. Find a solution you like and click `Accept Solution`.
8. Your `Member.cs` 파일이 업데이트됩니다.

### ⌨️ 활동: 코드스페이스에서 저장소로 코드 푸시하기

GitHub Copilot을 사용해 변경 사항을 요약한 뒤 코드를 커밋해봅시다.

1. **Source Control** 탭을 엽니다.
2. **Message** 입력란에서 ✨ 버튼을 눌러 Copilot이 메시지를 생성하도록 합니다.

![Copilot을 사용해 메시지를 생성하는 커밋 탭](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. **Commit** 버튼을 클릭하세요.

[연습의 4단계로 이동](./4-copilot-comment.md)

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 노력하고 있으나, 자동 번역에는 오류나 부정확성이 포함될 수 있습니다. 원본 문서의 원어 버전이 권위 있는 자료로 간주되어야 합니다. 중요한 정보의 경우, 전문 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.