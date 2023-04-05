import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View, Button, Alert } from 'react-native';
import Cat from './components/componentsElementsList/Cat';
import TaskCreate from './components/componentsElementsList/oneTask';

export default function App() {
  return (
    <View style={styles.container}>     
      <Button onPress=TaskCreate title="AddList"/>
      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
