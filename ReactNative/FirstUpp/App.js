import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, SafeAreaView, Button, Alert, Image, TouchableHighlight, View, Platform } from 'react-native';


export default function App() {
  const handleTextPress = () => console.log('Text pressed');
  const handleButtonPress = () => Alert.alert('Name', 'Message', [
    {text: "Yes", onPress: ()=> console.log('Yess')},
    {text: "Cansel", onPress: ()=> console.log('Cancel')}
  ]);

  const handleButtonPress2 = () => Alert.prompt('Name', 'Message', [
    {text: "Yes", onPress: text => console.log(text)},
    {text: "Cansel", onPress: ()=> console.log('Cancel')}
  ]);

  return (
    <SafeAreaView style={styles.container}>
      <Text style={styles.text} onPress={handleTextPress}> testing </Text>
      <Button title={"Pres"} onPress={handleButtonPress}/>
      <Button title={"Pres2"} onPress={handleButtonPress2}/>

      <TouchableHighlight onPress={handleButtonPress}>
      <Image blurRadius={0} source={require('./assets/favicon.png')}/>
      </TouchableHighlight>
      
      <View style={styles.box}>

      </View>

      <StatusBar style="auto" />
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',

  },
  text : {
    color: 'red'
  },
  box : {
    backgroundColor: 'green',
    width: '25%',
    height: '15%',
    opacity: 0.9,
    borderWidth: '1%',
    borderColor: 'red',
    borderStyle: 'dotted',
    top: Platform.OS === "ios " ? 160 : 30
       }
});
