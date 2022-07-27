mergeInto(LibraryManager.library, {
  ButtonClicked: function (count) {
    window.dispatchReactUnityEvent(
      "ButtonClicked",
      count
    );
  },
});

