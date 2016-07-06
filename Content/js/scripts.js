$(document).ready(function() {

  $("#p1button").unbind("click").click(function() {
    $("#player-one-turn").hide();
    $("#player-two-turn").show();
  });
  $("#p2button").unbind("click").submit(function() {
    $("#player-two-turn").hide();
    $("#player-one-turn").show();
  });
});
