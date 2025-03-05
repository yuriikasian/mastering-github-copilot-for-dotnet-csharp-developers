## 4단계: Copilot을 활용하여 주석으로 코드 생성하기

_Copilot 탭을 잘 활용하셨네요!_ 🎉

이제 Copilot의 빠른 탭 자동 제안과 Copilot 허브를 활용하여 AI가 생성한 제안을 수락하는 방법을 익히셨습니다.

이제 주석을 활용하여 Copilot 제안을 생성하는 방법을 알아보겠습니다!

### ⌨️ 활동: 주석으로 Copilot 제안 코드를 생성하기

1. Solution Explorer에서 codespace 내부에서 프로젝트를 우클릭하여 새 파일을 생성합니다.

> 참고: 위에서 Codespace를 닫았다면 다시 열거나 새 Codespace를 생성하세요.

2. **Class**를 선택하고 파일 이름을 `Comments.cs`으로 지정합니다.
3. **Comments** 클래스 내부에 다음 주석을 입력합니다:
   ```
   // create a method that generates a comment for a given skill
   ```
4. `enter` to go to a new line.
5. Copilot will suggest a code block.
6. Hover over the red squiggly and select the `...`

   > **Note**
   > If you don't see the copilot code block suggestion or the red squiggly and the three dots `...`, you can type `control + enter` to bring up the GitHub Copilot completions panel.

7. Click `Open Completions Panel`. Copilot will synthesise around 10 different code suggestions. You should see something like this:
   ![VS Code showing suggestions to a comment](../../../../03-Introduction-to-GitHub-Copilot/steps/img/4-copilot-comment-0.png)
8. Find a solution you like and click `Accept Solution`을 누릅니다.
9. `Comments.cs` 파일이 솔루션으로 업데이트됩니다.

### ⌨️ 활동: Codespace에서 리포지토리로 코드 푸시하기

GitHub Copilot을 사용하여 변경 내용을 요약하고 코드를 커밋해 봅시다.

1. **Source Control** 탭을 엽니다.
2. **Message** 입력란에서 ✨ 버튼을 눌러 Copilot이 메시지를 생성하도록 합니다.

![Copilot으로 메시지를 생성하는 Commit 탭](../../../../03-Introduction-to-GitHub-Copilot/steps/img/2-skills-commit.png)

3. **Commit** 버튼을 클릭합니다.

[Exercise 4 - Using GitHub Copilot with C#](../../04-Using-GitHub-Copilot-with-CSharp/README.md)로 이동하세요.

**면책 조항**:  
이 문서는 기계 기반 AI 번역 서비스를 사용하여 번역되었습니다. 정확성을 위해 노력하고 있지만, 자동 번역에는 오류나 부정확성이 포함될 수 있음을 유의하시기 바랍니다. 원본 문서의 해당 언어 버전이 권위 있는 출처로 간주되어야 합니다. 중요한 정보에 대해서는 전문적인 인간 번역을 권장합니다. 이 번역 사용으로 인해 발생하는 오해나 잘못된 해석에 대해 당사는 책임을 지지 않습니다.