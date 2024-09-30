## Requirement Specification for Flowcoach

### Actors
- **User**
- **Administrator**

### Subsystem 01: User/Login System
1. The user shall see a screen to choose between login and sign up.
2. The user shall be able to create an account using an email and password.
   - **Validation:** The email must contain "@" and be at least 2 characters long.
3. The system shall validate the user's email by sending a one-time activation code.
4. The user's password shall be encrypted when stored.
5. The user shall be able to sign up for a subscription to Flowcoach.
6. The user shall be able to sign in using their email and password.
7. The user's login session shall be cached for ease of use.

### Subsystem 02: Change/Selfcare
1. The user shall see a grid of "Cards" (images with text and description) after logging in.
2. The user shall be able to select a "card" to navigate to the corresponding Emotion Panel.

### Subsystem 03: Emotion Panel
1. The user shall see a grid of "Cards" (images with text) after logging in.
2. The user shall be able to select a "card" to navigate to the corresponding Q&A page.
3. The user shall be able to scroll through the emotion panel.

### Subsystem 04: Q&A
1. The user shall be able to read information about the selected emotion.
2. The user shall be able to answer questions related to the emotion.
3. The user shall be prompted to choose how they would like to feel from a predefined list.
4. Based on the user's choice, they shall be redirected to a specific page.
5. The user's responses shall be automatically saved to their journal.

### Subsystem 05: Psychoeducation
1. The user shall see a grid of "cards" (images with text) after selecting BodyFlow.
2. The user shall be able to choose a "Sensation" to read about.
3. The user shall have the option to return to the BodyFlow main page.

### Subsystem 06: Journal
1. The user shall be able to access their journal.
2. The user shall be able to re-read their saved responses within the journal.

### Subsystem 07: Push Notifications
1. The user shall have the option to enable push notifications.
2. Notifications shall inform the user about their growth and progress.
3. Notifications shall be sent every four days.

### Subsystem 08: Administrator System
1. The administrator shall access a separate website for app management.
2. The administrator shall be able to:
   - Add new content to the emotion panel.
   - Add new content to the Q&A page.
   - Add new content to the BodyFlow page.
   - Add new content to the Psychoeducation page.
3. The administrator shall be able to:
   - Remove content from the emotion panel.
   - Remove content from the Q&A page.
   - Remove content from the BodyFlow page.
   - Remove content from the Psychoeducation page.
4. The administrator shall be able to:
   - Update content in the emotion panel.
   - Update content in the Q&A page.
   - Update content in the BodyFlow page.
   - Update content in the Psychoeducation page.

### Subsystem 09: Payment System
1. The user shall be able to navigate to the payment page and back to the main page.
2. The payment page design shall be finalized before implementation.
3. Note: There will be no payment system as this is a prototype.
